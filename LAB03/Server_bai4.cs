using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LAB03
{
    public partial class Server_bai4 : Form
    {
        private TcpListener tcpserver;
        private Thread thread;
        public Server_bai4()
        {
            InitializeComponent();
        }

        private void SetLog(string str)
        {
            tbMessage.Invoke((MethodInvoker)delegate ()
            {
                tbMessage.AppendText(str + "\r\n");
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

                // Phản hồi

                // Gửi phản hồi cho client
                byte[] responseData = Encoding.UTF8.GetBytes(mess);
                networkStream.Write(responseData, 0, responseData.Length);
                networkStream.Flush();

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

        private void btStart_Click(object sender, EventArgs e)
        {
            try
            {
                tcpserver = new TcpListener(IPAddress.Any, 8080);
                tcpserver.Start();
                thread = new Thread(new ThreadStart(ListenforClient));
                thread.Start();
                MessageBox.Show("Server đã bắt đầu lắng nghe!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi: " + ex.Message);
            }
        }
    }
}
