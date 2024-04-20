using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace LAB03
{
    public partial class bai4 : Form
    {
        private TcpListener server;
        private Thread listenThread;

        public bai4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Server_bai4 FromN2 = new Server_bai4();
            FromN2.ShowDialog();
            bai4 FromN = new bai4();
            FromN.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Client_bai4 FromN = new Client_bai4();
            FromN.ShowDialog();
        }
    }
}
