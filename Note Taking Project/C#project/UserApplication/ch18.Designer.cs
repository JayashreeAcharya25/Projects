﻿namespace WindowsFormsApplication1
{
    partial class ch18
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ch18));
            this.doubleBufferPanel1 = new WindowsFormsApplication1.DoubleBufferPanel();
            this.doubleBufferPanel3 = new WindowsFormsApplication1.DoubleBufferPanel();
            this.label14 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmdDownload = new System.Windows.Forms.Button();
            this.cmdSelect = new System.Windows.Forms.Button();
            this.doubleBufferPanel2 = new WindowsFormsApplication1.DoubleBufferPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label17 = new System.Windows.Forms.Label();
            this.cmdImage = new System.Windows.Forms.Button();
            this.cmdWord = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdCopy = new System.Windows.Forms.Button();
            this.doubleBufferPanel1.SuspendLayout();
            this.doubleBufferPanel3.SuspendLayout();
            this.doubleBufferPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // doubleBufferPanel1
            // 
            this.doubleBufferPanel1.BackColor = System.Drawing.Color.DimGray;
            this.doubleBufferPanel1.Controls.Add(this.doubleBufferPanel3);
            this.doubleBufferPanel1.Controls.Add(this.label7);
            this.doubleBufferPanel1.Controls.Add(this.label8);
            this.doubleBufferPanel1.Controls.Add(this.label9);
            this.doubleBufferPanel1.Controls.Add(this.label10);
            this.doubleBufferPanel1.Controls.Add(this.cmdDownload);
            this.doubleBufferPanel1.Controls.Add(this.cmdSelect);
            this.doubleBufferPanel1.Controls.Add(this.doubleBufferPanel2);
            this.doubleBufferPanel1.Controls.Add(this.label6);
            this.doubleBufferPanel1.Controls.Add(this.pictureBox2);
            this.doubleBufferPanel1.Controls.Add(this.label5);
            this.doubleBufferPanel1.Controls.Add(this.label4);
            this.doubleBufferPanel1.Controls.Add(this.label3);
            this.doubleBufferPanel1.Controls.Add(this.label2);
            this.doubleBufferPanel1.Controls.Add(this.label1);
            this.doubleBufferPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.doubleBufferPanel1.Location = new System.Drawing.Point(0, 0);
            this.doubleBufferPanel1.Name = "doubleBufferPanel1";
            this.doubleBufferPanel1.Size = new System.Drawing.Size(911, 772);
            this.doubleBufferPanel1.TabIndex = 4;
            // 
            // doubleBufferPanel3
            // 
            this.doubleBufferPanel3.BackColor = System.Drawing.Color.DimGray;
            this.doubleBufferPanel3.Controls.Add(this.cmdCopy);
            this.doubleBufferPanel3.Controls.Add(this.label14);
            this.doubleBufferPanel3.Location = new System.Drawing.Point(615, 607);
            this.doubleBufferPanel3.Name = "doubleBufferPanel3";
            this.doubleBufferPanel3.Size = new System.Drawing.Size(269, 150);
            this.doubleBufferPanel3.TabIndex = 91;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(74, 21);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(116, 23);
            this.label14.TabIndex = 78;
            this.label14.Text = "Select Path";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(27, 311);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(302, 18);
            this.label7.TabIndex = 78;
            this.label7.Text = "Redirecting the standard streams";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(26, 444);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(329, 18);
            this.label8.TabIndex = 77;
            this.label8.Text = "Using StringReader and StringWriter";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(27, 402);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(200, 18);
            this.label9.TabIndex = 76;
            this.label9.Text = "Using memory stream";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(27, 357);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(289, 18);
            this.label10.TabIndex = 75;
            this.label10.Text = "Reading and writing binary data";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // cmdDownload
            // 
            this.cmdDownload.BackColor = System.Drawing.Color.Red;
            this.cmdDownload.FlatAppearance.BorderSize = 0;
            this.cmdDownload.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.cmdDownload.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.cmdDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdDownload.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdDownload.ForeColor = System.Drawing.Color.White;
            this.cmdDownload.Location = new System.Drawing.Point(416, 693);
            this.cmdDownload.Name = "cmdDownload";
            this.cmdDownload.Size = new System.Drawing.Size(175, 64);
            this.cmdDownload.TabIndex = 74;
            this.cmdDownload.Text = "Download";
            this.cmdDownload.UseVisualStyleBackColor = false;
            this.cmdDownload.Click += new System.EventHandler(this.cmdDownload_Click);
            // 
            // cmdSelect
            // 
            this.cmdSelect.BackColor = System.Drawing.Color.Red;
            this.cmdSelect.FlatAppearance.BorderSize = 0;
            this.cmdSelect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.cmdSelect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.cmdSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdSelect.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSelect.ForeColor = System.Drawing.Color.White;
            this.cmdSelect.Location = new System.Drawing.Point(30, 693);
            this.cmdSelect.Name = "cmdSelect";
            this.cmdSelect.Size = new System.Drawing.Size(175, 64);
            this.cmdSelect.TabIndex = 73;
            this.cmdSelect.Text = "Open Files";
            this.cmdSelect.UseVisualStyleBackColor = false;
            this.cmdSelect.Click += new System.EventHandler(this.cmdSelect_Click);
            // 
            // doubleBufferPanel2
            // 
            this.doubleBufferPanel2.Controls.Add(this.pictureBox1);
            this.doubleBufferPanel2.Controls.Add(this.label17);
            this.doubleBufferPanel2.Controls.Add(this.cmdImage);
            this.doubleBufferPanel2.Controls.Add(this.cmdWord);
            this.doubleBufferPanel2.Location = new System.Drawing.Point(63, 478);
            this.doubleBufferPanel2.Name = "doubleBufferPanel2";
            this.doubleBufferPanel2.Size = new System.Drawing.Size(481, 206);
            this.doubleBufferPanel2.TabIndex = 69;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(411, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label17.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(79, 61);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(289, 18);
            this.label17.TabIndex = 9;
            this.label17.Text = "Choose any Options to Open Files";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmdImage
            // 
            this.cmdImage.BackColor = System.Drawing.Color.Red;
            this.cmdImage.FlatAppearance.BorderSize = 0;
            this.cmdImage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.cmdImage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.cmdImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdImage.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdImage.ForeColor = System.Drawing.Color.White;
            this.cmdImage.Location = new System.Drawing.Point(268, 119);
            this.cmdImage.Name = "cmdImage";
            this.cmdImage.Size = new System.Drawing.Size(148, 54);
            this.cmdImage.TabIndex = 8;
            this.cmdImage.Text = "Image";
            this.cmdImage.UseVisualStyleBackColor = false;
            this.cmdImage.Click += new System.EventHandler(this.cmdImage_Click);
            // 
            // cmdWord
            // 
            this.cmdWord.BackColor = System.Drawing.Color.Red;
            this.cmdWord.FlatAppearance.BorderSize = 0;
            this.cmdWord.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.cmdWord.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.cmdWord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdWord.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdWord.ForeColor = System.Drawing.Color.White;
            this.cmdWord.Location = new System.Drawing.Point(45, 119);
            this.cmdWord.Name = "cmdWord";
            this.cmdWord.Size = new System.Drawing.Size(148, 54);
            this.cmdWord.TabIndex = 7;
            this.cmdWord.Text = "Word";
            this.cmdWord.UseVisualStyleBackColor = false;
            this.cmdWord.Click += new System.EventHandler(this.cmdWord_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(27, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(224, 18);
            this.label6.TabIndex = 29;
            this.label6.Text = "C#\'s I/O built in streams";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(844, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(67, 41);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 28;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(26, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(223, 18);
            this.label5.TabIndex = 27;
            this.label5.Text = "Character based file I/O";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(27, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(338, 18);
            this.label4.TabIndex = 26;
            this.label4.Text = "FileStream and Byte-Oriented file I/O";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(27, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 18);
            this.label3.TabIndex = 25;
            this.label3.Text = "Console I/O";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(26, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 18);
            this.label2.TabIndex = 24;
            this.label2.Text = "Stream classes";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(350, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 32);
            this.label1.TabIndex = 23;
            this.label1.Text = "Using I/O";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cmdCopy
            // 
            this.cmdCopy.BackColor = System.Drawing.Color.Red;
            this.cmdCopy.FlatAppearance.BorderSize = 0;
            this.cmdCopy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.cmdCopy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.cmdCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdCopy.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCopy.ForeColor = System.Drawing.Color.White;
            this.cmdCopy.Location = new System.Drawing.Point(36, 75);
            this.cmdCopy.Name = "cmdCopy";
            this.cmdCopy.Size = new System.Drawing.Size(197, 45);
            this.cmdCopy.TabIndex = 95;
            this.cmdCopy.Text = "Choose file to Copy";
            this.cmdCopy.UseVisualStyleBackColor = false;
            this.cmdCopy.Click += new System.EventHandler(this.cmdCopy_Click);
            // 
            // ch18
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(911, 772);
            this.Controls.Add(this.doubleBufferPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ch18";
            this.Text = "ch18";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ch18_Load);
            this.doubleBufferPanel1.ResumeLayout(false);
            this.doubleBufferPanel1.PerformLayout();
            this.doubleBufferPanel3.ResumeLayout(false);
            this.doubleBufferPanel3.PerformLayout();
            this.doubleBufferPanel2.ResumeLayout(false);
            this.doubleBufferPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DoubleBufferPanel doubleBufferPanel1;
        private System.Windows.Forms.Button cmdDownload;
        private System.Windows.Forms.Button cmdSelect;
        private DoubleBufferPanel doubleBufferPanel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button cmdImage;
        private System.Windows.Forms.Button cmdWord;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private DoubleBufferPanel doubleBufferPanel3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button cmdCopy;
    }
}