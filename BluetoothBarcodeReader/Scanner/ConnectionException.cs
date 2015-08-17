using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BluetoothBarcodeReader.Scanner
{
    class ConnectionException : Exception
    {
        public ConnectionException()
        {
        }
        public ConnectionException( string p )
            : base( p )
        {
        }

        public ConnectionException( string message, Exception inner )
            : base( message, inner )
        {
        }
    }
}
