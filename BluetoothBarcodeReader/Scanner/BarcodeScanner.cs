using System;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;

namespace BluetoothBarcodeReader.Scanner
{
    class BarcodeScanner
    {
        public bool IsConnected { get; private set; }

        private const string NEWLINE = "\x0d";
        private SerialPort _port;

        private bool _continue_monitoring;

        public virtual void OnScanReceived( ScanData scan_data )
        {
        }

        public virtual void OnScanError( string message )
        {
            MessageBox.Show( message, "Scan Error" );
        }

        private Thread _scan_thread;

        public void Connect()
        {
            try {
                _port = new SerialPort( "COM6", 115200, Parity.None, 8, StopBits.One ) {
                    ReadTimeout = 1000,
                    WriteTimeout = 1000,
                    NewLine = NEWLINE
                };

                _scan_thread = new Thread( new ThreadStart( ScanThread_Main ) );
                _scan_thread.Start();
                while ( !_scan_thread.IsAlive ) { ; }

                IsConnected = true;
            }
            catch ( Exception e ) {
                throw new ConnectionException( "Could not connect to device." );
            }
        }

        public void StopMonitoring()
        {
            _continue_monitoring = false;
        }

        public void Disconnect()
        {
            StopMonitoring();

            try {
                if ( _port.IsOpen )
                    _port.Close();
            }
            catch {
                ;
            }

            IsConnected = false;
        }

        private void ScanThread_Main()
        {
            Random random = new Random();

            _continue_monitoring = true;
            while ( _continue_monitoring ) {
                Console.WriteLine( "Anus! " + random.Next( 0, 1000 ) );
            }
        }


    }
}
