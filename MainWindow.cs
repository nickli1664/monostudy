using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace linuxcc2
{
    public partial class lccMainWindow : Form
    {
        public lccMainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = false;
            fileDialog.Title = "Please choose your file.";
            fileDialog.Filter = "All file(*.*)|*.*";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string file = fileDialog.FileName;
                MessageBox.Show("Selected:" + file, "Choose file tips", MessageBoxButtons.OK, MessageBoxIcon.Information);
                button1.Text = file;
                FileInfo fileInfo = new FileInfo(file);
                label3.Text = fileInfo.Length.ToString() + " Byte";
            }
        }

    }
}