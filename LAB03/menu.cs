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

        private void label4_Click(object sender, EventArgs e)
        {
            bai4 FromN = new bai4();
            FromN.ShowDialog();
       
        }
    }
}
