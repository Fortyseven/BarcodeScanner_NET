using System;
using System.Diagnostics;
using System.IO.Ports;
using System.Text;

namespace BluetoothBarcodeReader.Scanner.Drivers
{
    public class KDC200 : BarcodeScanner
    {
        private const int STREAM_START = 3;
        private const int STREAM_END = '@';
        private const int NUL = 0;
        private const int RECEIVE_TIMEOUT_MS = 1000;

        private const int PREAMBLE_NBYTES = 5;

        private enum State { IDLE, PREAMBLE, CODE, SYMB };
        private State CurrentState { get; set; }

        private readonly Stopwatch _last_received_timer;
        private int _preamble_byte_count;
        private StringBuilder _code;

        /// <summary>
        /// 
        /// </summary>
        public KDC200()
        {
            CurrentState = State.IDLE;
            _last_received_timer = new Stopwatch();
            _last_received_timer.Start();
        }

        /// <summary>
        /// Whenever data is received on the serial port, this callback runs.
        /// Because we can't rely on the stream to start or end reliably,  we 
        /// have to maintain a state machine to potentially parse  the data 
        /// in chunks.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected override void OnDataReceived( object sender, SerialDataReceivedEventArgs e )
        {
            // Time out and reset state if we don't conclude fast enough
            if ( _last_received_timer.ElapsedMilliseconds > RECEIVE_TIMEOUT_MS ) {
                CurrentState = State.IDLE;
                _last_received_timer.Reset();
            }

            while ( _port.BytesToRead > 0 ) {
                int ch = _port.ReadByte();
                _last_received_timer.Reset();
                processIncomingByte( ch );
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ch"></param>
        private void processIncomingByte( int ch )
        {
            switch ( CurrentState ) {
                case State.IDLE:
                    if ( ch == STREAM_START ) {
                        CurrentState = State.PREAMBLE;
                        _preamble_byte_count = PREAMBLE_NBYTES;
                    }
                    break;
                case State.PREAMBLE:
                    _preamble_byte_count--;
                    if ( _preamble_byte_count == 0 ) {
                        CurrentState = State.CODE;
                        _code = new StringBuilder( 0 );
                    }
                    break;
                case State.CODE:
                    if ( ch == NUL ) {
                        CurrentState = State.SYMB;
                    }
                    _code.Append( (char)ch );
                    break;
                case State.SYMB:
                    // Going to ignore the symbology part for the moment
                    if ( ch == STREAM_END ) {
                        CurrentState = State.IDLE;
                        if ( OnScanData != null ) {
                            packScan();
                        }
                    }
                    break;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void packScan()
        {
            ScanData sd = new ScanData();
            sd.code = _code.ToString();
            sd.symb = Symbology.UNKNOWN;
            OnScanData( sd );
        }
    }
}