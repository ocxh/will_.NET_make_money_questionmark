using System;
using System.Windows.Forms;

namespace WindowsFormsApp_basic_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("버튼이 클릭됨!");
        }
    }
}
