using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace piracy_client
{
    public partial class utility : Form
    {
        public utility()
        {
            InitializeComponent();
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            pictureBox2.Width = btnCal.Width;
            pictureBox2.Top = btnCal.Top;

            System.Diagnostics.Process.Start("calc.exe");
        }

        private void btnNotepad_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            pictureBox2.Width = btnNotepad.Width;
            pictureBox2.Top = btnNotepad.Top;

            System.Diagnostics.Process.Start("notepad.exe");
        }

        private void btnEMI_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            pictureBox2.Width = btnEMI.Width;
            pictureBox2.Top = btnEMI.Top;
        }
    }
}
