using System;
using System.Windows.Forms;

namespace ovningsuppgifter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTryck_Click(object sender, EventArgs e)
        {
            lbText.Text = "Hello World!";
        }

        
    }
}
