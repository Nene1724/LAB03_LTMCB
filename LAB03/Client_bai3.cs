using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LAB03
{
    public partial class Client_bai3 : Form
    {
        private TcpClient client;
        private NetworkStream stream;
        public Client_bai3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            client = new TcpClient("127.0.0.1", 8080);
            stream = client.GetStream();
            try
            {
                if (client != null && client.Connected)
                {
                    byte[] data = Encoding.UTF8.GetBytes("XIN CHAO SERVER");
                    stream.Write(data, 0, data.Length);

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
