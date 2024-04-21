using System.Runtime.Intrinsics.X86;

namespace LAB03
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }
        private void label2_Click_1(object sender, EventArgs e)
        {
            bai2 FromN = new bai2();
            FromN.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            bai3 FromN = new bai3();
            FromN.Show();
            Client_bai3 FromN2 = new Client_bai3();
            FromN2.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Server_bai1 FromN = new Server_bai1();
            FromN.Show();
            Client_bai1 FromN2 = new Client_bai1();
            FromN2.Show();
        }
    }
}
