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
    public partial class Server_bai1 : Form
    {
        private UdpClient udpserver;
        private Thread thread;

        public Server_bai1()
        {

            InitializeComponent();
        }

        void receiveData()
        {
            try
            {
                while (true)
                {
                    IPEndPoint remoteEndPoint = new IPEndPoint(IPAddress.Any, 0);
                    byte[] Data = udpserver.Receive(ref remoteEndPoint);
                    string mess = Encoding.UTF8.GetString(Data);

                    Invoke(new Action(() =>
                    {
                        textBox2.Text = "Nhận từ " + mess + "\n";
                    }));

                    string respondMess = "Đã nhận thành công!";
                    byte[] respondData = Encoding.UTF8.GetBytes(respondMess);
                    udpserver.Send(respondData, respondData.Length, remoteEndPoint);
                }
            }
            catch
            {
                MessageBox.Show("Có lỗi!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int port = Int32.Parse(textBox1.Text.Trim());
            IPEndPoint localEndPoint = new IPEndPoint(IPAddress.Any, port);

            try
            {
                udpserver = new UdpClient(localEndPoint);
                thread = new Thread(new ThreadStart(receiveData));
                thread.Start();
                MessageBox.Show("Máy chủ đang chạy");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi");
            }
        }
    }
}
