using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;
using System.Xml.Linq;

namespace LAB03
{
    public partial class Client_bai4 : Form
    {
        private TcpClient client;
        private NetworkStream stream;
        public Client_bai4()
        {
            InitializeComponent();
        }
        private void SetLog(string T)
        {
            tbRespond.Invoke((MethodInvoker)delegate ()
            {
                tbRespond.AppendText(T + "\r\n");
                Application.DoEvents();
            });
        }

        private void btSend_Click(object sender, EventArgs e)
        {
            client = new TcpClient("127.0.0.1", 8080);
            stream = client.GetStream();
            try
            {
                if (client != null && client.Connected)
                {
                    string name = tbName.Text;
                    string mess = tbSend.Text;
                    byte[] data = Encoding.UTF8.GetBytes(name + ": " + mess);
                    stream.Write(data, 0, data.Length);
                    tbSend.Clear();


                    byte[] buffer = new byte[4096];
                    int byteRead = stream.Read(buffer, 0, buffer.Length);
                    string mess1 = Encoding.UTF8.GetString(buffer, 0, byteRead);
                    SetLog(mess1);
                }
                else
                {
                    MessageBox.Show("Có lỗi! Không thể gửi đến server");
                }
            }
            catch
            {
                MessageBox.Show("Có lỗi! Không thể gửi đến server");
            }
        }
    }
}
