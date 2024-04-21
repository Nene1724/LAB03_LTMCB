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
        private Server_bai4 serverForm;
        private Client_bai4 clientForm;

        public bai4()
        {
            InitializeComponent();
            serverForm = new Server_bai4();
            clientForm = new Client_bai4();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            serverForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clientForm.Show();
        }
    }

}
