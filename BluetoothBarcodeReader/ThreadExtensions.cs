using System;
using System.ComponentModel;

public static class ThreadExtensions
{
    // Courtesy of casperOne - http://stackoverflow.com/a/571727
    public static void SynchronizedInvoke( this ISynchronizeInvoke sync, Action action )
    {
        if ( !sync.InvokeRequired ) {
            action();
            return;
        }
        try {
            sync.Invoke( action, new object[] { } );
        }
        catch {
            // Eat exception; probably from a closed window.  Never eat exceptions.

            // FIXED: Somtimes the page thread wouldn't stop before the form was 
            // closed, causing an exception. This has been fixed, but I'm keeping 
            // this here anyway because I'm insecure.  That and if this happens, it
            // won't really matter because we're gone. Point is: the root cause has
            // been taken care of, and that's all that matters.
        }
    }
}