namespace EmbeddedProjectControl
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.txtComPort = new System.Windows.Forms.TextBox();
            this.lblComPort = new System.Windows.Forms.Label();
            this.lblBaudrate = new System.Windows.Forms.Label();
            this.txtBaudrate = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.lblTempLabel = new System.Windows.Forms.Label();
            this.lblLightLabel = new System.Windows.Forms.Label();
            this.tbBulb = new System.Windows.Forms.TrackBar();
            this.lblBulb = new System.Windows.Forms.Label();
            this.lblFan = new System.Windows.Forms.Label();
            this.tbFan = new System.Windows.Forms.TrackBar();
            this.lblTemp = new System.Windows.Forms.Label();
            this.lblLight = new System.Windows.Forms.Label();
            this.lblFanSpeed = new System.Windows.Forms.Label();
            this.lblBulbIntensity = new System.Windows.Forms.Label();
            this.fieldRefreshTimer = new System.Windows.Forms.Timer(this.components);
            this.dataPollTimer = new System.Windows.Forms.Timer(this.components);
            this.gbState = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.tbBulb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFan)).BeginInit();
            this.gbState.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort
            // 
            this.serialPort.PortName = "COM10";
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_DataReceived);
            // 
            // txtComPort
            // 
            this.txtComPort.Location = new System.Drawing.Point(53, 12);
            this.txtComPort.Name = "txtComPort";
            this.txtComPort.Size = new System.Drawing.Size(67, 20);
            this.txtComPort.TabIndex = 0;
            this.txtComPort.Text = "COM10";
            // 
            // lblComPort
            // 
            this.lblComPort.AutoSize = true;
            this.lblComPort.Location = new System.Drawing.Point(18, 15);
            this.lblComPort.Name = "lblComPort";
            this.lblComPort.Size = new System.Drawing.Size(29, 13);
            this.lblComPort.TabIndex = 1;
            this.lblComPort.Text = "Port:";
            // 
            // lblBaudrate
            // 
            this.lblBaudrate.AutoSize = true;
            this.lblBaudrate.Location = new System.Drawing.Point(129, 15);
            this.lblBaudrate.Name = "lblBaudrate";
            this.lblBaudrate.Size = new System.Drawing.Size(53, 13);
            this.lblBaudrate.TabIndex = 3;
            this.lblBaudrate.Text = "Baudrate:";
            // 
            // txtBaudrate
            // 
            this.txtBaudrate.Location = new System.Drawing.Point(188, 12);
            this.txtBaudrate.Name = "txtBaudrate";
            this.txtBaudrate.Size = new System.Drawing.Size(50, 20);
            this.txtBaudrate.TabIndex = 2;
            this.txtBaudrate.Text = "9600";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(261, 11);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(86, 21);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // lblTempLabel
            // 
            this.lblTempLabel.AutoSize = true;
            this.lblTempLabel.Location = new System.Drawing.Point(29, 35);
            this.lblTempLabel.Name = "lblTempLabel";
            this.lblTempLabel.Size = new System.Drawing.Size(70, 13);
            this.lblTempLabel.TabIndex = 5;
            this.lblTempLabel.Text = "Temperature:";
            // 
            // lblLightLabel
            // 
            this.lblLightLabel.AutoSize = true;
            this.lblLightLabel.Location = new System.Drawing.Point(25, 64);
            this.lblLightLabel.Name = "lblLightLabel";
            this.lblLightLabel.Size = new System.Drawing.Size(74, 13);
            this.lblLightLabel.TabIndex = 7;
            this.lblLightLabel.Text = "Light intensity:";
            // 
            // tbBulb
            // 
            this.tbBulb.LargeChange = 10;
            this.tbBulb.Location = new System.Drawing.Point(28, 130);
            this.tbBulb.Maximum = 1023;
            this.tbBulb.Name = "tbBulb";
            this.tbBulb.Size = new System.Drawing.Size(282, 45);
            this.tbBulb.TabIndex = 9;
            this.tbBulb.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tbBulb_MouseUp);
            // 
            // lblBulb
            // 
            this.lblBulb.AutoSize = true;
            this.lblBulb.Location = new System.Drawing.Point(25, 110);
            this.lblBulb.Name = "lblBulb";
            this.lblBulb.Size = new System.Drawing.Size(97, 13);
            this.lblBulb.TabIndex = 10;
            this.lblBulb.Text = "Light bulb intensity:";
            // 
            // lblFan
            // 
            this.lblFan.AutoSize = true;
            this.lblFan.Location = new System.Drawing.Point(25, 176);
            this.lblFan.Name = "lblFan";
            this.lblFan.Size = new System.Drawing.Size(60, 13);
            this.lblFan.TabIndex = 12;
            this.lblFan.Text = "Fan speed:";
            // 
            // tbFan
            // 
            this.tbFan.LargeChange = 10;
            this.tbFan.Location = new System.Drawing.Point(28, 196);
            this.tbFan.Maximum = 1023;
            this.tbFan.Name = "tbFan";
            this.tbFan.Size = new System.Drawing.Size(282, 45);
            this.tbFan.TabIndex = 11;
            this.tbFan.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tbFan_MouseUp);
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemp.Location = new System.Drawing.Point(105, 35);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(31, 13);
            this.lblTemp.TabIndex = 13;
            this.lblTemp.Text = "0 *C";
            // 
            // lblLight
            // 
            this.lblLight.AutoSize = true;
            this.lblLight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLight.Location = new System.Drawing.Point(105, 64);
            this.lblLight.Name = "lblLight";
            this.lblLight.Size = new System.Drawing.Size(14, 13);
            this.lblLight.TabIndex = 14;
            this.lblLight.Text = "0";
            // 
            // lblFanSpeed
            // 
            this.lblFanSpeed.AutoSize = true;
            this.lblFanSpeed.Location = new System.Drawing.Point(82, 176);
            this.lblFanSpeed.Name = "lblFanSpeed";
            this.lblFanSpeed.Size = new System.Drawing.Size(21, 13);
            this.lblFanSpeed.TabIndex = 15;
            this.lblFanSpeed.Text = "0%";
            // 
            // lblBulbIntensity
            // 
            this.lblBulbIntensity.AutoSize = true;
            this.lblBulbIntensity.Location = new System.Drawing.Point(119, 110);
            this.lblBulbIntensity.Name = "lblBulbIntensity";
            this.lblBulbIntensity.Size = new System.Drawing.Size(21, 13);
            this.lblBulbIntensity.TabIndex = 16;
            this.lblBulbIntensity.Text = "0%";
            // 
            // fieldRefreshTimer
            // 
            this.fieldRefreshTimer.Enabled = true;
            this.fieldRefreshTimer.Interval = 10;
            this.fieldRefreshTimer.Tick += new System.EventHandler(this.fieldRefreshTimer_Tick);
            // 
            // dataPollTimer
            // 
            this.dataPollTimer.Enabled = true;
            this.dataPollTimer.Interval = 500;
            this.dataPollTimer.Tick += new System.EventHandler(this.dataPollTimer_Tick);
            // 
            // gbState
            // 
            this.gbState.Controls.Add(this.tbBulb);
            this.gbState.Controls.Add(this.lblBulbIntensity);
            this.gbState.Controls.Add(this.lblTempLabel);
            this.gbState.Controls.Add(this.lblFanSpeed);
            this.gbState.Controls.Add(this.lblLightLabel);
            this.gbState.Controls.Add(this.lblLight);
            this.gbState.Controls.Add(this.lblBulb);
            this.gbState.Controls.Add(this.lblTemp);
            this.gbState.Controls.Add(this.tbFan);
            this.gbState.Controls.Add(this.lblFan);
            this.gbState.Enabled = false;
            this.gbState.Location = new System.Drawing.Point(12, 47);
            this.gbState.Name = "gbState";
            this.gbState.Size = new System.Drawing.Size(335, 248);
            this.gbState.TabIndex = 17;
            this.gbState.TabStop = false;
            this.gbState.Text = "Device state:";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 309);
            this.Controls.Add(this.gbState);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.lblBaudrate);
            this.Controls.Add(this.txtBaudrate);
            this.Controls.Add(this.lblComPort);
            this.Controls.Add(this.txtComPort);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Device Control";
            ((System.ComponentModel.ISupportInitialize)(this.tbBulb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFan)).EndInit();
            this.gbState.ResumeLayout(false);
            this.gbState.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.TextBox txtComPort;
        private System.Windows.Forms.Label lblComPort;
        private System.Windows.Forms.Label lblBaudrate;
        private System.Windows.Forms.TextBox txtBaudrate;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label lblTempLabel;
        private System.Windows.Forms.Label lblLightLabel;
        private System.Windows.Forms.TrackBar tbBulb;
        private System.Windows.Forms.Label lblBulb;
        private System.Windows.Forms.Label lblFan;
        private System.Windows.Forms.TrackBar tbFan;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.Label lblLight;
        private System.Windows.Forms.Label lblFanSpeed;
        private System.Windows.Forms.Label lblBulbIntensity;
        private System.Windows.Forms.Timer fieldRefreshTimer;
        private System.Windows.Forms.Timer dataPollTimer;
        private System.Windows.Forms.GroupBox gbState;
    }
}

