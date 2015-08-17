using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BluetoothBarcodeReader.Scanner;

namespace BluetoothBarcodeReader
{
    public partial class MainForm : Form
    {
        private BarcodeScanner bs;

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load( object sender, EventArgs e )
        {
            cbBaud.SelectedIndex = 0;

            bs = new BarcodeScanner();
            bs.Connect();
        }

        private void btnConnect_Click( object sender, EventArgs e )
        {
            if ( bs.IsConnected ) {
                bs.Disconnect();
            }
            else {
                bs.Connect();
            }

        }


    }
}
