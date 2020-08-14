namespace WindowsFormsApplication1
{
    partial class ch2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ch2));
            this.doubleBufferPanel1 = new WindowsFormsApplication1.DoubleBufferPanel();
            this.doubleBufferPanel3 = new WindowsFormsApplication1.DoubleBufferPanel();
            this.cmdCopy = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.doubleBufferPanel2 = new WindowsFormsApplication1.DoubleBufferPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label17 = new System.Windows.Forms.Label();
            this.cmdImage = new System.Windows.Forms.Button();
            this.cmdWord = new System.Windows.Forms.Button();
            this.cmdDownload = new System.Windows.Forms.Button();
            this.cmdSelect = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.doubleBufferPanel1.Controls.Add(this.doubleBufferPanel2);
            this.doubleBufferPanel1.Controls.Add(this.cmdDownload);
            this.doubleBufferPanel1.Controls.Add(this.cmdSelect);
            this.doubleBufferPanel1.Controls.Add(this.pictureBox2);
            this.doubleBufferPanel1.Controls.Add(this.label12);
            this.doubleBufferPanel1.Controls.Add(this.label11);
            this.doubleBufferPanel1.Controls.Add(this.label10);
            this.doubleBufferPanel1.Controls.Add(this.label9);
            this.doubleBufferPanel1.Controls.Add(this.label7);
            this.doubleBufferPanel1.Controls.Add(this.label6);
            this.doubleBufferPanel1.Controls.Add(this.label5);
            this.doubleBufferPanel1.Controls.Add(this.label4);
            this.doubleBufferPanel1.Controls.Add(this.label3);
            this.doubleBufferPanel1.Controls.Add(this.label2);
            this.doubleBufferPanel1.Controls.Add(this.label1);
            this.doubleBufferPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.doubleBufferPanel1.Location = new System.Drawing.Point(0, 0);
            this.doubleBufferPanel1.Name = "doubleBufferPanel1";
            this.doubleBufferPanel1.Size = new System.Drawing.Size(836, 772);
            this.doubleBufferPanel1.TabIndex = 0;
            // 
            // doubleBufferPanel3
            // 
            this.doubleBufferPanel3.BackColor = System.Drawing.Color.Transparent;
            this.doubleBufferPanel3.Controls.Add(this.cmdCopy);
            this.doubleBufferPanel3.Controls.Add(this.label8);
            this.doubleBufferPanel3.Location = new System.Drawing.Point(555, 618);
            this.doubleBufferPanel3.Name = "doubleBufferPanel3";
            this.doubleBufferPanel3.Size = new System.Drawing.Size(269, 150);
            this.doubleBufferPanel3.TabIndex = 76;
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
            this.cmdCopy.Location = new System.Drawing.Point(37, 73);
            this.cmdCopy.Name = "cmdCopy";
            this.cmdCopy.Size = new System.Drawing.Size(197, 45);
            this.cmdCopy.TabIndex = 80;
            this.cmdCopy.Text = "Choose file to Copy";
            this.cmdCopy.UseVisualStyleBackColor = false;
            this.cmdCopy.Click += new System.EventHandler(this.cmdCopy_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(74, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 23);
            this.label8.TabIndex = 78;
            this.label8.Text = "Select Path";
            // 
            // doubleBufferPanel2
            // 
            this.doubleBufferPanel2.Controls.Add(this.pictureBox1);
            this.doubleBufferPanel2.Controls.Add(this.label17);
            this.doubleBufferPanel2.Controls.Add(this.cmdImage);
            this.doubleBufferPanel2.Controls.Add(this.cmdWord);
            this.doubleBufferPanel2.Location = new System.Drawing.Point(21, 476);
            this.doubleBufferPanel2.Name = "doubleBufferPanel2";
            this.doubleBufferPanel2.Size = new System.Drawing.Size(481, 206);
            this.doubleBufferPanel2.TabIndex = 70;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(408, 0);
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
            this.label17.Location = new System.Drawing.Point(80, 54);
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
            this.cmdImage.Location = new System.Drawing.Point(274, 111);
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
            this.cmdWord.Location = new System.Drawing.Point(65, 111);
            this.cmdWord.Name = "cmdWord";
            this.cmdWord.Size = new System.Drawing.Size(148, 54);
            this.cmdWord.TabIndex = 7;
            this.cmdWord.Text = "Word";
            this.cmdWord.UseVisualStyleBackColor = false;
            this.cmdWord.Click += new System.EventHandler(this.cmdWord_Click);
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
            this.cmdDownload.Location = new System.Drawing.Point(353, 704);
            this.cmdDownload.Name = "cmdDownload";
            this.cmdDownload.Size = new System.Drawing.Size(175, 64);
            this.cmdDownload.TabIndex = 44;
            this.cmdDownload.Text = "Download";
            this.cmdDownload.UseVisualStyleBackColor = false;
            this.cmdDownload.Click += new System.EventHandler(this.button1_Click);
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
            this.cmdSelect.Location = new System.Drawing.Point(21, 704);
            this.cmdSelect.Name = "cmdSelect";
            this.cmdSelect.Size = new System.Drawing.Size(175, 64);
            this.cmdSelect.TabIndex = 43;
            this.cmdSelect.Text = "Open Files";
            this.cmdSelect.UseVisualStyleBackColor = false;
            this.cmdSelect.Click += new System.EventHandler(this.cmdSelect_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(768, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(68, 41);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 42;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click_1);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(30, 437);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 18);
            this.label12.TabIndex = 41;
            this.label12.Text = "label12";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(30, 390);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(197, 18);
            this.label11.TabIndex = 40;
            this.label11.Text = "Operator precedence";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(30, 349);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(194, 18);
            this.label10.TabIndex = 39;
            this.label10.Text = "Boxing and Unboxing";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(30, 314);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 18);
            this.label9.TabIndex = 38;
            this.label9.Text = "Type Coversion";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(30, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(220, 18);
            this.label7.TabIndex = 37;
            this.label7.Text = "Variables and Constants";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(30, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 18);
            this.label6.TabIndex = 36;
            this.label6.Text = "Data Types";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(30, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(230, 18);
            this.label5.TabIndex = 35;
            this.label5.Text = "Identifiers and Keywords";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(30, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(347, 18);
            this.label4.TabIndex = 34;
            this.label4.Text = "Creating simple C# Console Application";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(30, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(255, 18);
            this.label3.TabIndex = 33;
            this.label3.Text = "C# Pre-processor Directives";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(30, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 18);
            this.label2.TabIndex = 32;
            this.label2.Text = "Need of C#";
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
            this.label1.Location = new System.Drawing.Point(305, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 32);
            this.label1.TabIndex = 31;
            this.label1.Text = "Introducing C#";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ch2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(836, 772);
            this.ControlBox = false;
            this.Controls.Add(this.doubleBufferPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ch2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdDownload;
        private System.Windows.Forms.Button cmdSelect;
        private DoubleBufferPanel doubleBufferPanel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button cmdImage;
        private System.Windows.Forms.Button cmdWord;
        private DoubleBufferPanel doubleBufferPanel3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button cmdCopy;

    }
}