using System.IO;
using System.IO.Compression;

namespace UnZipper
{
    public partial class UnZipper : Form
    {
        private string filePath = "base";
        public UnZipper()
        {
            InitializeComponent();
        }

        private void UnZipper_Load(object sender, EventArgs e)
        {

        }

        private void UnZip_Click(object sender, EventArgs e)
        {
            if (filePath == "base")
            {
                MessageBox.Show("Make sure to select valid FilePath", "Error: Invalid FilePath", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string[] filePaths = Directory.GetFiles(filePath, "*.zip");
                progressBar1.Maximum = filePaths.Length;
                foreach (string x in filePaths)
                {
                    label2.Text = x;
                    DirectoryInfo di = Directory.CreateDirectory(filePath + @"\" + Path.GetFileNameWithoutExtension(x));
                    System.IO.Compression.ZipFile.ExtractToDirectory(@x, filePath + @"\" + Path.GetFileNameWithoutExtension(x), true);
                    progressBar1.Increment(1);
                }
                MessageBox.Show("Decompression is complete!", "Process Completed:", MessageBoxButtons.OK, MessageBoxIcon.Information);
                progressBar1.Value = 0;
                label2.Text = "";
            }
           
        }

        private void browse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog diag = new FolderBrowserDialog();
            if (diag.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                filePath = diag.SelectedPath;  //selected folder path
                fileName.Text = filePath;
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}