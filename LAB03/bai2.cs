using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace LAB03
{
    public partial class bai2 : Form
    {
        private const int port = 8080;
        private TcpListener listener;
        private Thread serverThread;
        private TcpClient client;
        private NetworkStream clientStream;

        public bai2()
        {
            InitializeComponent();      
        }


        private void StartUnsafeThread()
        {
            byte[] buffer = new byte[4096];
            string rcv = "";

            // Tạo socket bên gửi 
            Socket clientSocket;
            // Tạo socket bên nhận/lắng nghe
            Socket listenerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint ipepServer = new IPEndPoint(IPAddress.Any, 8080);

            try
            {
                // Bind và lắng nghe kết nối
                listenerSocket.Bind(ipepServer);
                listenerSocket.Listen(-1);
                MessageBox.Show("Máy chủ đang chạy !");

                // Chấp nhận kết nối đến
                clientSocket = listenerSocket.Accept();
                listView1.Items.Add(new ListViewItem("Đã kết nối, đang lắng nghe thông điệp  \n"));

                while (clientSocket.Connected)
                {
                    int bytesRead = clientSocket.Receive(buffer);
                    if (bytesRead == 0)
                    {
                        break;
                    }

                    // Giải mã các byte nhận được thành chuỗi và thêm vào receivedMessage
                    rcv += Encoding.UTF8.GetString(buffer, 0, bytesRead);

                    // Kiểm tra xem ký tự cuối cùng của receivedMessage có phải là xuống dòng hay không
                    if (rcv.EndsWith("\n"))
                    {
                        // Thêm receivedMessage vào ListView
                        AddMessageToListView(rcv);

                        // Đặt lại receivedMessage để nhận dòng tiếp theo
                        rcv = "";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                // Đóng socket lắng nghe khi kết thúc
                if (listenerSocket != null)
                    listenerSocket.Close();
            }
        }

        private void AddMessageToListView(string message)
        {
            if (listView1.InvokeRequired)
            {
                // Nếu gọi hàm từ một luồng khác với luồng giao diện người dùng, thì thực hiện Invoke để gọi lại
                listView1.Invoke(new MethodInvoker(() => AddMessageToListView(message)));
            }
            else
            {
                // Thêm dòng vào ListView
                listView1.Items.Add(message);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Thread serverThread = new Thread(new ThreadStart(StartUnsafeThread));
            serverThread.Start();
      
        }

    }
}
