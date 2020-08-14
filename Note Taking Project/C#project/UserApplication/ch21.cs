using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class ch21 : Form
    {
        public ch21()
        {
            InitializeComponent();
        }

        private void ch21_Load(object sender, EventArgs e)
        {
            Image myimage = new Bitmap(@"C:\Users\PERSONAL\Desktop\c#\images\image2.jpg");
            this.BackgroundImage = myimage;
            doubleBufferPanel1.BackColor = Color.FromArgb(125, Color.Black);

            doubleBufferPanel2.Visible = false;
            doubleBufferPanel2.BackColor = Color.FromArgb(125, Color.Black);
            doubleBufferPanel3.Visible = false;
            doubleBufferPanel3.BackColor = Color.FromArgb(125, Color.Black);
        }


        private void label2_Click(object sender, EventArgs e)
        {
            MsgBox mb = new MsgBox();
            mb.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            MsgBox mb = new MsgBox();
            mb.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            MsgBox mb = new MsgBox();
            mb.Show();
        }

        private void cmdSelect_Click(object sender, EventArgs e)
        {
            doubleBufferPanel2.Visible = true;
        }

        private void cmdWord_Click(object sender, EventArgs e)
        {
            OpenFileDialog opd = new OpenFileDialog();
            opd.InitialDirectory = @"C:\Users\PERSONAL\Desktop\c#\ch21\Word";
            if (opd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string filepath = opd.FileName;
                Process.Start(filepath);
            }
        }

        private void cmdImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog opd = new OpenFileDialog();
            opd.InitialDirectory = @"C:\Users\PERSONAL\Desktop\c#\ch21\Image";
            if (opd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string filepath = opd.FileName;
                Process.Start(filepath);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            doubleBufferPanel2.Visible = false;
        }

        private void cmdDownload_Click(object sender, EventArgs e)
        {
            doubleBufferPanel3.Visible = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdCopy_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Title = "select file to copy";
            f.InitialDirectory = @"C:\Users\PERSONAL\Desktop\c#\ch21";
            if (f.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string CopyTo = f.FileName;
                FolderBrowserDialog b1 = new FolderBrowserDialog();
                if (b1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string PasteTo = b1.SelectedPath + "//" + Path.GetFileName(f.FileName);

                    MessageBox.Show(b1.SelectedPath);

                    string path = PasteTo;
                    if (File.Exists(path))
                    {
                        MessageBox.Show("file already exisit");
                    }
                    else
                    {
                        File.Copy(CopyTo, PasteTo);
                        MessageBox.Show("File Copied to New Folder");
                        return;
                    }

                }
                else
                {
                    // Throw error or alert
                }

            }
        }
    }
}
