﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Word;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.IO;

namespace WindowsFormsApplication1
{

    public partial class ch3 : Form
    {

        public ch3()
        {
            InitializeComponent();
        }

        private void ch3_Load(object sender, EventArgs e)
        {

            Image myimage = new Bitmap(@"C:\Users\PERSONAL\Desktop\c#\images\image2.jpg");
            this.BackgroundImage = myimage;
            doubleBufferPanel1.BackColor = Color.FromArgb(125, Color.Black);

            doubleBufferPanel2.Visible = false;
            doubleBufferPanel2.BackColor = Color.FromArgb(125, Color.Black);
            doubleBufferPanel3.Visible = false;
            doubleBufferPanel3.BackColor = Color.FromArgb(125, Color.Black);
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            MsgBox mb = new MsgBox();
            mb.Show();

        }
        private void label3_Click_1(object sender, EventArgs e)
        {
            MsgBox mb = new MsgBox();
            mb.Show();

        }
        private void label4_Click_1(object sender, EventArgs e)
        {
            MsgBox mb = new MsgBox();
            mb.Show();
        }
        private void label5_Click_1(object sender, EventArgs e)
        {
            MsgBox mb = new MsgBox();
            mb.Show();
        }

        private void label6_Click_1(object sender, EventArgs e)
        {
            MsgBox mb = new MsgBox();
            mb.Show();
        }

        private void label8_Click_1(object sender, EventArgs e)
        {
            MsgBox mb = new MsgBox();
            mb.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            MsgBox mb = new MsgBox();
            mb.Show();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            MsgBox mb = new MsgBox();
            mb.Show();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            MsgBox mb = new MsgBox();
            mb.Show();
        }

        private void label14_Click(object sender, EventArgs e)
        {
            MsgBox mb = new MsgBox();
            mb.Show();
        }

        private void label15_Click(object sender, EventArgs e)
        {
            MsgBox mb = new MsgBox();
            mb.Show();
        }

        private void cmdOk_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdSelect_Click(object sender, EventArgs e)
        {
            //Open File
            doubleBufferPanel2.Visible = true;
        }

        private void cmdWord_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog opd = new OpenFileDialog();
            opd.InitialDirectory = @"C:\Users\PERSONAL\Desktop\c#\ch3\Word";
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

        private void cmdDownload1_Click(object sender, EventArgs e)
        {

            doubleBufferPanel3.Visible = true;
        }

        private void cmdImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog opd = new OpenFileDialog();
            opd.InitialDirectory = @"C:\Users\PERSONAL\Desktop\c#\ch3\Image";
            if (opd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string filepath = opd.FileName;
                Process.Start(filepath);
            }
        }

        private void cmdCopy_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Title = "select file to copy";
            f.InitialDirectory = @"C:\Users\PERSONAL\Desktop\c#\ch3";
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




 


