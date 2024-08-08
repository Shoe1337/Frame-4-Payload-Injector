using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using System.Net.Sockets;
using System.IO;
using System.Net;

namespace frame4_injector
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
            bool flag = this.Payload_BGWorker == null;
            if (flag)
            {
                this.Payload_BGWorker = new BackgroundWorker();
                this.Payload_BGWorker.DoWork += this.Payload_BGWorker_DoWork;
            }
        }
        private readonly string Shoe = Path.Combine(Application.StartupPath, "Frame4.bin");
        private void Payload_BGWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                this.SocketConnection(this.ipbox.Text, this.Shoe, int.Parse(this.portbox.Text));
            }
            catch (FormatException)
            {
                this.Status("Invalid port number.");
            }
        }
        private BackgroundWorker Payload_BGWorker;
        private void button1_Click(object sender, EventArgs e)
        {
            bool flag = !string.IsNullOrEmpty(this.ipbox.Text) && !string.IsNullOrEmpty(this.portbox.Text);
            if (flag)
            {
                this.Status("Injecting payload...");
                this.Payload_BGWorker.RunWorkerAsync();
            }
            else
            {
                MessageBox.Show("Please enter PS4 IP address and port.");
            }
        }
        private void SocketConnection(string IP, string Payload, int port)
        {
            try
            {
                using (Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp))
                {
                    socket.ReceiveTimeout = 1500;
                    socket.SendTimeout = 1500;
                    socket.Connect(new IPEndPoint(IPAddress.Parse(IP), port));
                    socket.SendFile(Payload);
                    this.StatusUp.ForeColor = Color.LawnGreen;
                    this.Status("Payload sent successfully.");
                    
                }
            }
            catch (FormatException)
            {
                this.Status("Invalid IP address or port number.");
            }
            catch (SocketException ex)
            {
                this.Status("Socket error: " + ex.Message);
            }
            catch (Exception ex2)
            {
                this.Status("An error occurred: " + ex2.Message);
            }
        }
        private void Status(string status)
        {
            bool invokeRequired = base.InvokeRequired;
            if (invokeRequired)
            {
                base.Invoke(new Action(delegate ()
                {
                    this.StatusUp.Text = status;
                }));
            }
            else
            {
                this.StatusUp.Text = status;
            }
        }
    }
}
