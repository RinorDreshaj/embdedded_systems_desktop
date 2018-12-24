using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EmbeddedProjectControl
{
    public partial class frmMain : Form
    {
        byte lastHeader;
        byte lastPayload;
        bool dirtyFields;
        int lastRequestedField;
        bool shouldRequestField;

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort.PortName = txtComPort.Text;
                serialPort.BaudRate = int.Parse(txtBaudrate.Text);

                serialPort.Open();

                gbState.Enabled = true;

                btnConnect.Enabled = false;
                lblComPort.Enabled = false;
                txtComPort.Enabled = false;
                lblBaudrate.Enabled = false;
                txtBaudrate.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not connect to device. Please make sure the device is connected and the COM port is correct!", "Error connecting", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void serialPort_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            if (dirtyFields)
                return;

            byte packetByte = (byte)serialPort.ReadByte();

            if ((packetByte & 0x80) != 0)
            {
                lastHeader = packetByte;
            }
            else
            {
                lastPayload = packetByte;
                dirtyFields = true;
            }
        }

        private void tbBulb_MouseUp(object sender, MouseEventArgs e)
        {
            sendPacket(2, tbBulb.Value);
            lblBulbIntensity.Text = (int)(100 * tbBulb.Value / 1023) + "%";
        }

        private void tbFan_MouseUp(object sender, MouseEventArgs e)
        {
            sendPacket(4, tbFan.Value);
            lblFanSpeed.Text = (int)(100 * tbFan.Value / 1023) + "%";
        }

        private void parsePacket(byte header, byte payload)
        {
            int field = (header >> 3) & 0x07;
            int value = ((header & 0x07) << 7) | payload;

            switch (field)
            {
                case 3:
                    float temperature = 500.0f * value / 1024.0f - 273.15f;
                    lblTemp.Text = temperature.ToString("0.00 *C");
                    break;

                case 1:
                    lblLight.Text = value.ToString();
                    break;
            }
        }

        private void sendPacket(int field, int value)
        {
            byte header = 0;
            byte payload = (byte)(value & 0x7F);

            header |= (byte)(0x80 | 0x40);
            header |= (byte)((field & 0x07) << 3);
            header |= (byte)((value >> 7) & 0x07);

            byte[] packet = { header, payload };

            serialPort.Write(packet, 0, packet.Length);
        }

        private void fieldRefreshTimer_Tick(object sender, EventArgs e)
        {
            if (dirtyFields)
            {
                dirtyFields = false;
                parsePacket(lastHeader, lastPayload);
            }

            if (shouldRequestField)
            {
                shouldRequestField = false;

                if (lastRequestedField % 2 == 0)
                    requestField(1);
                else
                    requestField(3);

                lastRequestedField++;
            }
        }

        private void dataPollTimer_Tick(object sender, EventArgs e)
        {
            if(serialPort.IsOpen)
            {
                shouldRequestField = true;
            }
        }

        private void requestField(byte field)
        {
            byte header = 0;

            header |= (byte)(0x80);
            header |= (byte)((field & 0x07) << 3);

            byte[] packet = { header };

            serialPort.Write(packet, 0, packet.Length);
        }
    }
}
