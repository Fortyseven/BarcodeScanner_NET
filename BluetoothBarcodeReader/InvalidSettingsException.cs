using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BluetoothBarcodeReader
{
    class InvalidSettingsException : Exception
    {
        public InvalidSettingsException( string p )
            : base( p )
        {
        }
    }
}
