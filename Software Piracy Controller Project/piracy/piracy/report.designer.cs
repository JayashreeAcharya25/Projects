namespace piracy
{
    partial class report
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(report));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rdbrequest = new System.Windows.Forms.RadioButton();
            this.rdbsent = new System.Windows.Forms.RadioButton();
            this.rdbapplied = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnprint = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 224);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(709, 185);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // rdbrequest
            // 
            this.rdbrequest.AutoSize = true;
            this.rdbrequest.Checked = true;
            this.rdbrequest.Location = new System.Drawing.Point(73, 86);
            this.rdbrequest.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbrequest.Name = "rdbrequest";
            this.rdbrequest.Size = new System.Drawing.Size(121, 21);
            this.rdbrequest.TabIndex = 1;
            this.rdbrequest.TabStop = true;
            this.rdbrequest.Text = "Key requested";
            this.rdbrequest.UseVisualStyleBackColor = true;
            this.rdbrequest.CheckedChanged += new System.EventHandler(this.rdbrequest_CheckedChanged);
            // 
            // rdbsent
            // 
            this.rdbsent.AutoSize = true;
            this.rdbsent.Location = new System.Drawing.Point(279, 86);
            this.rdbsent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbsent.Name = "rdbsent";
            this.rdbsent.Size = new System.Drawing.Size(84, 21);
            this.rdbsent.TabIndex = 2;
            this.rdbsent.TabStop = true;
            this.rdbsent.Text = "Key sent";
            this.rdbsent.UseVisualStyleBackColor = true;
            this.rdbsent.CheckedChanged += new System.EventHandler(this.rdbsent_CheckedChanged);
            // 
            // rdbapplied
            // 
            this.rdbapplied.AutoSize = true;
            this.rdbapplied.Location = new System.Drawing.Point(459, 86);
            this.rdbapplied.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbapplied.Name = "rdbapplied";
            this.rdbapplied.Size = new System.Drawing.Size(103, 21);
            this.rdbapplied.TabIndex = 3;
            this.rdbapplied.TabStop = true;
            this.rdbapplied.Text = "Key applied";
            this.rdbapplied.UseVisualStyleBackColor = true;
            this.rdbapplied.CheckedChanged += new System.EventHandler(this.rdbapplied_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(709, 31);
            this.panel1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(660, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnprint
            // 
            this.btnprint.Location = new System.Drawing.Point(552, 165);
            this.btnprint.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(100, 28);
            this.btnprint.TabIndex = 5;
            this.btnprint.Text = "Print";
            this.btnprint.UseVisualStyleBackColor = true;
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(251, 139);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 62);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 409);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnprint);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rdbapplied);
            this.Controls.Add(this.rdbsent);
            this.Controls.Add(this.rdbrequest);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbrequest;
        private System.Windows.Forms.RadioButton rdbsent;
        private System.Windows.Forms.RadioButton rdbapplied;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnprint;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}