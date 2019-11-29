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

        private void button6_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count == 1)
            {
                Int32 drv = dataGridView1.SelectedRows[0].Index;
                Int32 drvend = dataGridView1.Rows.Count;
                drvend--;

                if (drv < drvend)
                {
                    //MessageBox.Show(drv.ToString() + "----" + drvend.ToString());
                    try
                    {
                        dataGridView1.Rows.RemoveAt(drv);
                    }
                    catch (Exception e1)
                    {
                        MessageBox.Show(e1.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("Don't select last row.", "Please select a row", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }     
            }
            else
            {
                MessageBox.Show("Please select one row. Don't select last row.", "Please select a row", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "Please choose path.";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string foldPath = dialog.SelectedPath;
                MessageBox.Show("Selected Path:" + foldPath, "Selected Path tips", MessageBoxButtons.OK, MessageBoxIcon.Information);
                button2.Text = foldPath; 
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "Please choose path.";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string foldPath = dialog.SelectedPath;
                MessageBox.Show("Selected Path:" + foldPath, "Selected Path tips", MessageBoxButtons.OK, MessageBoxIcon.Information);
                button3.Text = foldPath;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button2.Text != "Click me to choose primary path" && button3.Text != "Click me to choose secondary path")
            {
                //MessageBox.Show("go");

                int index = this.dataGridView1.Rows.Add();
                this.dataGridView1.Rows[index].Cells[0].Value = button2.Text;
                this.dataGridView1.Rows[index].Cells[1].Value = button3.Text;
            }
            else
            {
                MessageBox.Show("Please choose primary&secondary path.", "Please choose primary&secondary path", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            int realrow = dataGridView1.RowCount-1;
            int realcolumn = dataGridView1.ColumnCount;
            int pairerrorflag = 0;

            if (realrow == 0)
            {
                pairerrorflag = 1;
                MessageBox.Show("Please add one pair at least.", "Please add pair", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                for (int i = 0; i < realrow; i++)
                {
                    for (int j = 0; j < realcolumn; j++)
                    {
                        //打印第i行第j列数据
                        //Console.WriteLine("##" + Convert.ToString(dataGridView1.Rows[i].Cells[j].Value));
                        string path = Convert.ToString(dataGridView1.Rows[i].Cells[j].Value);
                        if (Directory.Exists(path))
                        {
                            
                        }
                        else
                        {
                            MessageBox.Show("Found error path:  " + path, "Error Path", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            pairerrorflag = 1;
                        }
                    }

                }
            }

            if (pairerrorflag == 0 && this.button5.Text == "Lock pair")
            {
                this.button5.Text = "Unlock pair";
                this.dataGridView1.ReadOnly = true;
                this.button2.Enabled = false;
                this.button3.Enabled = false;
                this.button4.Enabled = false;
                this.button6.Enabled = false;
            }
            else
            {
                this.button5.Text = "Lock pair";
                this.dataGridView1.ReadOnly = false;
                this.button2.Enabled = true;
                this.button3.Enabled = true;
                this.button4.Enabled = true;
                this.button6.Enabled = true;
            }
        }
    }
}