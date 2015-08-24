using System;
using System.IO.Ports;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using BluetoothBarcodeReader.Scanner;
using BluetoothBarcodeReader.Scanner.Drivers;

namespace BluetoothBarcodeReader
{
    public partial class MainForm : Form
    {
        private KDC200 _bs;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_FormLoad( object sender, EventArgs e )
        {
            cbBaud.SelectedIndex = cbBaud.Items.Count - 1;
            cbDataBits.SelectedIndex = cbDataBits.Items.Count - 1;
            cbStopBits.SelectedIndex = 1;
            cbParity.SelectedIndex = 0;

            PopulatePorts();
        }

        private void MainForm_FormClosed( object sender, FormClosedEventArgs e )
        {
            Disconnect();
        }

        private void cbPort_DropDown( object sender, EventArgs e )
        {
            PopulatePorts();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="ev"></param>
        private void btnConnect_Click( object sender, EventArgs ev )
        {
            if ( _bs != null && _bs.IsConnected ) {
                _bs.Disconnect();
                btnConnect.Text = "Connect";
            }
            else {
                try {
                    _bs = new KDC200();
                    _bs.OnScanData = OnScanDataCallback;
                    SetValuesFromSettings( _bs );
                    _bs.Connect();
                    btnConnect.Text = "Disconnect";
                }
                catch ( InvalidSettingsException ex ) {
                    MessageBox.Show( ex.Message, "Settings Error",
                                     MessageBoxButtons.OK, MessageBoxIcon.Error );
                }
                catch ( Exception ex ) {
                    MessageBox.Show( ex.Message, "Connection Error",
                                     MessageBoxButtons.OK, MessageBoxIcon.Error );
                }
            }
        }

        private void OnScanDataCallback( ScanData scan )
        {
            Console.WriteLine( "> " + scan.code + " [" + scan.symb.ToString() + "]\n" );
        }


        /// <summary>
        /// Query Windows for the serial ports attached; populate port combobox with contents
        /// </summary>
        private void PopulatePorts()
        {
            cbPort.Items.Clear();

            string[] ports = SerialPort.GetPortNames();

            if ( ports.Length == 0 ) {
                MessageBox.Show( "No serial ports reported.", "Device Error" );
                return;
            }
            foreach ( string port in ports ) {
                // Normalize com port name thanks to occasionally buggy Bluetooth drivers
                cbPort.Items.Add( Regex.Match( port, @"COM\d+" ).Value );
            }

            cbPort.SelectedIndex = 0;
        }

        /// <summary>
        /// Set serial port configuration based on form controls
        /// </summary>
        /// <param name="scanner"></param>
        private void SetValuesFromSettings( BarcodeScanner scanner )
        {
            int number;

            scanner.SerialPortName = cbPort.Text;

            Int32.TryParse( cbBaud.Text, out number );
            scanner.SerialBaud = number;

            Int32.TryParse( cbDataBits.Text, out number );
            scanner.SerialDataBits = number;

            switch ( cbParity.Text ) {
                case "None":
                    scanner.SerialParity = Parity.None;
                    break;
                case "Even":
                    scanner.SerialParity = Parity.Even;
                    break;
                case "Odd":
                    scanner.SerialParity = Parity.Odd;
                    break;
                case "Mark":
                    scanner.SerialParity = Parity.Mark;
                    break;
                case "Space":
                    scanner.SerialParity = Parity.Space;
                    break;
            }

            switch ( cbStopBits.Text ) {
                //case "None":
                //    bs.SerialStopBits = StopBits.None;
                //    break;
                case "1":
                    scanner.SerialStopBits = StopBits.One;
                    break;
                case "1.5":
                    scanner.SerialStopBits = StopBits.OnePointFive;
                    break;
                case "2":
                    scanner.SerialStopBits = StopBits.Two;
                    break;
            }
        }

        private void Disconnect()
        {
            if ( _bs != null && _bs.IsConnected ) {
                _bs.Disconnect();
            }
        }

    }
}
