using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileAppender
{
    public partial class MainForm : Form
    {
        private const int BUFFER_SIZE = 32768;

        public MainForm()
        {
            InitializeComponent();
        }

        public static void openFile(string title, TextBox output)
        {
            using (OpenFileDialog open = new OpenFileDialog()
            {
                Title = title
            })
            {
                if (open.ShowDialog() != DialogResult.OK)
                {
                    return;
                }
                output.Text = open.FileName;
            }
        }

        private void btnInputBrowser_Click(object sender, EventArgs e)
        {
            openFile("請選擇來源檔案", txtInput);
        }

        private void btnAppendBrowser_Click(object sender, EventArgs e)
        {
            openFile("請選擇附加檔案", txtAppend);
        }

        private void btnOutputBrowser_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog save = new SaveFileDialog()
            {
                Filter = "所有檔案 (*.*)|*.*",
                Title = "請指定輸出檔案"
            })
            {
                if (save.ShowDialog() != DialogResult.OK)
                {
                    return;
                }
                txtOutput.Text = save.FileName;
            }
        }

        public static void writeAllByte(FileStream src, FileStream dst)
        {
            byte[] buffer = new byte[BUFFER_SIZE];
            int readByte;
            while ((readByte = src.Read(buffer, 0, buffer.Length)) > 0)
            {
                dst.Write(buffer, 0, readByte);
            }
        }

        private void enableControl(bool enable)
        {
            btnInputBrowser.Enabled = btnAppendBrowser.Enabled = btnOutputBrowser.Enabled = btnProcess.Enabled = enable;
        }

        private async void btnProcess_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtInput.Text) || string.IsNullOrWhiteSpace(txtAppend.Text) || string.IsNullOrWhiteSpace(txtOutput.Text))
            {
                MessageBox.Show("請指定輸入、附加、輸出檔案", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            enableControl(false);
            try
            {
                await Task.Run(() =>
                {
                    using (FileStream input = new FileStream(txtInput.Text, FileMode.Open, FileAccess.Read))
                    {
                        using (FileStream append = new FileStream(txtAppend.Text, FileMode.Open, FileAccess.Read))
                        {
                            using (FileStream output = new FileStream(txtOutput.Text, FileMode.Create, FileAccess.Write))
                            {
                                writeAllByte(input, output);
                                writeAllByte(append, output);
                            }
                        }
                    }
                });
                MessageBox.Show("檔案處理完成", "資訊", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("處理檔案時發生例外狀況 : " + ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            enableControl(true);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(Environment.ExitCode);
        }
    }
}