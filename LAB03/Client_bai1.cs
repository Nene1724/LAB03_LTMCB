using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB03
{
    public partial class Client_bai1 : Form
    {
        private UdpClient client;
        public Client_bai1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                IPAddress serverIP = IPAddress.Parse(textBox1.Text);
                int port = Int32.Parse(textBox2.Text.Trim());
                IPEndPoint serverEndPoint = new IPEndPoint(serverIP, port);

                client = new UdpClient();

                string mess = textBox1.Text +": "+ textBox3.Text;

                byte[] data = Encoding.UTF8.GetBytes(mess);
                client.Send(data, data.Length, serverEndPoint);
                textBox3.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi !");
            }
        }
    }
}
