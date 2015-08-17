namespace BluetoothBarcodeReader
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if ( disposing && ( components != null ) ) {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupConnection = new System.Windows.Forms.GroupBox();
            this.cbStopBits = new System.Windows.Forms.ComboBox();
            this.lblStopBits = new System.Windows.Forms.Label();
            this.cbDataBits = new System.Windows.Forms.ComboBox();
            this.labelDataBits = new System.Windows.Forms.Label();
            this.cbParity = new System.Windows.Forms.ComboBox();
            this.lblParity = new System.Windows.Forms.Label();
            this.cbBaud = new System.Windows.Forms.ComboBox();
            this.lblBaud = new System.Windows.Forms.Label();
            this.cbPort = new System.Windows.Forms.ComboBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.groupConnection.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupConnection
            // 
            this.groupConnection.Controls.Add(this.btnConnect);
            this.groupConnection.Controls.Add(this.cbStopBits);
            this.groupConnection.Controls.Add(this.lblStopBits);
            this.groupConnection.Controls.Add(this.cbDataBits);
            this.groupConnection.Controls.Add(this.labelDataBits);
            this.groupConnection.Controls.Add(this.cbParity);
            this.groupConnection.Controls.Add(this.lblParity);
            this.groupConnection.Controls.Add(this.cbBaud);
            this.groupConnection.Controls.Add(this.lblBaud);
            this.groupConnection.Controls.Add(this.cbPort);
            this.groupConnection.Controls.Add(this.lblPort);
            this.groupConnection.Location = new System.Drawing.Point(12, 12);
            this.groupConnection.Name = "groupConnection";
            this.groupConnection.Size = new System.Drawing.Size(416, 77);
            this.groupConnection.TabIndex = 0;
            this.groupConnection.TabStop = false;
            this.groupConnection.Text = "Connection";
            // 
            // cbStopBits
            // 
            this.cbStopBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStopBits.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbStopBits.FormattingEnabled = true;
            this.cbStopBits.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2"});
            this.cbStopBits.Location = new System.Drawing.Point(359, 42);
            this.cbStopBits.Name = "cbStopBits";
            this.cbStopBits.Size = new System.Drawing.Size(39, 21);
            this.cbStopBits.TabIndex = 9;
            // 
            // lblStopBits
            // 
            this.lblStopBits.AutoSize = true;
            this.lblStopBits.Location = new System.Drawing.Point(307, 48);
            this.lblStopBits.Name = "lblStopBits";
            this.lblStopBits.Size = new System.Drawing.Size(49, 13);
            this.lblStopBits.TabIndex = 8;
            this.lblStopBits.Text = "Stop Bits";
            // 
            // cbDataBits
            // 
            this.cbDataBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDataBits.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbDataBits.FormattingEnabled = true;
            this.cbDataBits.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.cbDataBits.Location = new System.Drawing.Point(260, 45);
            this.cbDataBits.Name = "cbDataBits";
            this.cbDataBits.Size = new System.Drawing.Size(39, 21);
            this.cbDataBits.TabIndex = 7;
            // 
            // labelDataBits
            // 
            this.labelDataBits.AutoSize = true;
            this.labelDataBits.Location = new System.Drawing.Point(207, 48);
            this.labelDataBits.Name = "labelDataBits";
            this.labelDataBits.Size = new System.Drawing.Size(50, 13);
            this.labelDataBits.TabIndex = 6;
            this.labelDataBits.Text = "Data Bits";
            // 
            // cbParity
            // 
            this.cbParity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbParity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbParity.FormattingEnabled = true;
            this.cbParity.Items.AddRange(new object[] {
            "None",
            "Even",
            "Odd",
            "Mark",
            "Space"});
            this.cbParity.Location = new System.Drawing.Point(140, 45);
            this.cbParity.Name = "cbParity";
            this.cbParity.Size = new System.Drawing.Size(63, 21);
            this.cbParity.TabIndex = 5;
            // 
            // lblParity
            // 
            this.lblParity.AutoSize = true;
            this.lblParity.Location = new System.Drawing.Point(108, 48);
            this.lblParity.Name = "lblParity";
            this.lblParity.Size = new System.Drawing.Size(33, 13);
            this.lblParity.TabIndex = 4;
            this.lblParity.Text = "Parity";
            // 
            // cbBaud
            // 
            this.cbBaud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBaud.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbBaud.FormattingEnabled = true;
            this.cbBaud.Items.AddRange(new object[] {
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14.4k",
            "19.2k",
            "38.4k",
            "57.6k",
            "115.2k"});
            this.cbBaud.Location = new System.Drawing.Point(39, 45);
            this.cbBaud.Name = "cbBaud";
            this.cbBaud.Size = new System.Drawing.Size(63, 21);
            this.cbBaud.TabIndex = 3;
            // 
            // lblBaud
            // 
            this.lblBaud.AutoSize = true;
            this.lblBaud.Location = new System.Drawing.Point(7, 48);
            this.lblBaud.Name = "lblBaud";
            this.lblBaud.Size = new System.Drawing.Size(32, 13);
            this.lblBaud.TabIndex = 2;
            this.lblBaud.Text = "Baud";
            // 
            // cbPort
            // 
            this.cbPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbPort.FormattingEnabled = true;
            this.cbPort.Location = new System.Drawing.Point(39, 17);
            this.cbPort.Name = "cbPort";
            this.cbPort.Size = new System.Drawing.Size(164, 21);
            this.cbPort.TabIndex = 1;
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(7, 20);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(26, 13);
            this.lblPort.TabIndex = 0;
            this.lblPort.Text = "Port";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(590, 243);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Scan Data";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(210, 15);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(188, 23);
            this.btnConnect.TabIndex = 10;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 350);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupConnection);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KDC200";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupConnection.ResumeLayout(false);
            this.groupConnection.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupConnection;
        private System.Windows.Forms.Label lblStopBits;
        private System.Windows.Forms.Label labelDataBits;
        private System.Windows.Forms.Label lblParity;
        private System.Windows.Forms.Label lblBaud;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.ComboBox cbStopBits;
        private System.Windows.Forms.ComboBox cbDataBits;
        private System.Windows.Forms.ComboBox cbParity;
        private System.Windows.Forms.ComboBox cbBaud;
        private System.Windows.Forms.ComboBox cbPort;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnConnect;
    }
}

