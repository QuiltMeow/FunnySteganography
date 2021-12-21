using System;
using System.Windows.Forms;

namespace SimplePayload
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnMeow_Click(object sender, EventArgs e)
        {
            MessageBox.Show("貓貓最可愛了唷 <3", "喵", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}