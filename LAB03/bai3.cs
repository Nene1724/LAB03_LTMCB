using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB03
{
    public partial class bai3 : Form
    {
        private TcpListener tcpserver;
        private Thread thread;

        public bai3()
        {
            InitializeComponent();
        }

        private void SetLog(string str)
        {
            textBox1.Invoke((MethodInvoker)delegate ()
            {
                textBox1.AppendText(str + "\r\n");
                Application.DoEvents();
            });
        }

        private void Handle(Object client)
        {
            TcpClient tcpClient = (TcpClient)client;
            NetworkStream networkStream = tcpClient.GetStream();
            byte[] Data = new byte[4096];
            int byteRead;

            while (true)
            {
                byteRead = 0;
                try
                {
                    byteRead = networkStream.Read(Data, 0, Data.Length);
                }
                catch
                {
                    break;
                }
                if (byteRead == 0)
                {
                    break;
                }
                string mess = Encoding.UTF8.GetString(Data, 0, byteRead);
                SetLog(mess);


            }
            networkStream.Close();
            tcpClient.Close();
        }

        private void ListenforClient()
        {
            while (true)
            {
                TcpClient client = tcpserver.AcceptTcpClient();
                Thread clientThread = new Thread(new ParameterizedThreadStart(Handle));
                clientThread.Start(client);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                tcpserver = new TcpListener(IPAddress.Any, 8080);
                tcpserver.Start();
                thread = new Thread(new ThreadStart(ListenforClient));
                thread.Start();
                SetLog ("Server đã bắt đầu lắng nghe trên 127.0.0.1:8080 !");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi: " + ex.Message);
            }
        }
    }
}
