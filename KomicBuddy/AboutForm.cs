using System;
using System.Windows.Forms;

namespace KomicBuddy
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void AboutForm_Load(object sender, EventArgs e)
        {
            label2.Text += Application.ProductVersion;
        }

        private void AboutForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Escape)
                return;

            e.SuppressKeyPress = true;
            Close();
        }
    }
}