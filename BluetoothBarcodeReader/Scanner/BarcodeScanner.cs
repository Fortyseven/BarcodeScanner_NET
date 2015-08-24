using System;
using System.IO.Ports;
using System.Windows.Forms;

/*
 *  Start - 3 (ETX)
 *  5 bytes
 *   [Start of BC ASCII representation]
 *  0 NUL
 *  Ends with '@'
 */

namespace BluetoothBarcodeReader.Scanner
{
    public class BarcodeScanner
    {
        public bool IsConnected { get; private set; }

        public string SerialPortName { get; set; }
        public int SerialBaud { get; set; }
        public Parity SerialParity { get; set; }
        public int SerialDataBits { get; set; }
        public StopBits SerialStopBits { get; set; }

        private const string NEWLINE = "\x0d";
        protected SerialPort _port;

        public delegate void OnScanDataCallback( ScanData scan );

        public OnScanDataCallback OnScanData = null;

        public virtual void OnScanError( string message )
        {
            MessageBox.Show( message, "Scan Error" );
        }

        //private Thread _scan_thread;

        public BarcodeScanner()
        {
            // Some sane defaults
            SerialBaud = 115200;
            SerialParity = Parity.None;
            SerialDataBits = 8;
            SerialStopBits = StopBits.One;
        }

        public void Connect()
        {
            if ( SerialPortName.Length == 0 )
                throw new InvalidSettingsException( "Serial port name is empty" );

            if ( SerialBaud < 300 )
                throw new InvalidSettingsException( "Serial port baud rate must be >= 300" );

            try {
                _port = new SerialPort( SerialPortName,
                                        SerialBaud,
                                        SerialParity,
                                        SerialDataBits,
                                        SerialStopBits ) {
                                            ReadTimeout = 1000,
                                            WriteTimeout = 1000,
                                            NewLine = NEWLINE
                                        };

                _port.Open();
                _port.DataReceived += OnDataReceived;

                //_scan_thread = new Thread( new ThreadStart( ScanThread_Main ) );
                //_scan_thread.Start();
                //while ( !_scan_thread.IsAlive ) { ; }

                IsConnected = true;
            }
            catch ( Exception e ) {
                throw new ConnectionException( "Could not connect to device: " + e );
            }
        }

        public void Disconnect()
        {
            try {
                if ( _port.IsOpen )
                    _port.Close();
            }
            catch {
                ;
            }

            IsConnected = false;
        }

        protected virtual void OnDataReceived( object sender, SerialDataReceivedEventArgs e )
        {
            throw new NotImplementedException();
        }
    }
}
