namespace WindowsFormsApplication1
{
    partial class ch1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ch1));
            this.doubleBufferPanel1 = new WindowsFormsApplication1.DoubleBufferPanel();
            this.doubleBufferPanel3 = new WindowsFormsApplication1.DoubleBufferPanel();
            this.cmdCopy = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cmdSelect = new System.Windows.Forms.Button();
            this.doubleBufferPanel2 = new WindowsFormsApplication1.DoubleBufferPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label17 = new System.Windows.Forms.Label();
            this.cmdImage = new System.Windows.Forms.Button();
            this.cmdWord = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.doubleBufferPanel1.Controls.Add(this.button1);
            this.doubleBufferPanel1.Controls.Add(this.cmdSelect);
            this.doubleBufferPanel1.Controls.Add(this.doubleBufferPanel2);
            this.doubleBufferPanel1.Controls.Add(this.pictureBox2);
            this.doubleBufferPanel1.Controls.Add(this.label6);
            this.doubleBufferPanel1.Controls.Add(this.label5);
            this.doubleBufferPanel1.Controls.Add(this.label4);
            this.doubleBufferPanel1.Controls.Add(this.label3);
            this.doubleBufferPanel1.Controls.Add(this.label1);
            this.doubleBufferPanel1.Controls.Add(this.label2);
            this.doubleBufferPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.doubleBufferPanel1.Location = new System.Drawing.Point(0, 0);
            this.doubleBufferPanel1.Name = "doubleBufferPanel1";
            this.doubleBufferPanel1.Size = new System.Drawing.Size(875, 667);
            this.doubleBufferPanel1.TabIndex = 0;
            // 
            // doubleBufferPanel3
            // 
            this.doubleBufferPanel3.BackColor = System.Drawing.Color.DimGray;
            this.doubleBufferPanel3.Controls.Add(this.cmdCopy);
            this.doubleBufferPanel3.Controls.Add(this.label21);
            this.doubleBufferPanel3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doubleBufferPanel3.Location = new System.Drawing.Point(594, 485);
            this.doubleBufferPanel3.Name = "doubleBufferPanel3";
            this.doubleBufferPanel3.Size = new System.Drawing.Size(269, 150);
            this.doubleBufferPanel3.TabIndex = 72;
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
            this.cmdCopy.Location = new System.Drawing.Point(26, 86);
            this.cmdCopy.Name = "cmdCopy";
            this.cmdCopy.Size = new System.Drawing.Size(197, 45);
            this.cmdCopy.TabIndex = 79;
            this.cmdCopy.Text = "Choose file to Copy";
            this.cmdCopy.UseVisualStyleBackColor = false;
            this.cmdCopy.Click += new System.EventHandler(this.cmdCopy_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(74, 21);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(116, 23);
            this.label21.TabIndex = 78;
            this.label21.Text = "Select Path";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(393, 571);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 64);
            this.button1.TabIndex = 71;
            this.button1.Text = "Download";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.cmdSelect.Location = new System.Drawing.Point(34, 571);
            this.cmdSelect.Name = "cmdSelect";
            this.cmdSelect.Size = new System.Drawing.Size(175, 64);
            this.cmdSelect.TabIndex = 70;
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
            this.doubleBufferPanel2.Location = new System.Drawing.Point(34, 325);
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
            this.pictureBox1.Location = new System.Drawing.Point(411, 3);
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
            this.label17.Location = new System.Drawing.Point(87, 44);
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
            this.cmdImage.Location = new System.Drawing.Point(264, 106);
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
            this.cmdWord.Location = new System.Drawing.Point(54, 106);
            this.cmdWord.Name = "cmdWord";
            this.cmdWord.Size = new System.Drawing.Size(148, 54);
            this.cmdWord.TabIndex = 7;
            this.cmdWord.Text = "Word";
            this.cmdWord.UseVisualStyleBackColor = false;
            this.cmdWord.Click += new System.EventHandler(this.cmdWord_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(806, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(69, 41);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(31, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 18);
            this.label6.TabIndex = 23;
            this.label6.Text = "Windows Forms";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(31, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(273, 18);
            this.label5.TabIndex = 22;
            this.label5.Text = ".NET Framework Class Library";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(31, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(653, 18);
            this.label4.TabIndex = 21;
            this.label4.Text = "Components of .NET Framework 4.0: CLR, CTS, Metadata and Assemblies";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(31, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(336, 18);
            this.label3.TabIndex = 20;
            this.label3.Text = "Architecuture of .NET Framework 4.0";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(199, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(634, 32);
            this.label1.TabIndex = 19;
            this.label1.Text = "Getting started with .NET Framework 4.0";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(31, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 18);
            this.label2.TabIndex = 18;
            this.label2.Text = "Benefits of .NET Framework";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // ch1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(875, 667);
            this.ControlBox = false;
            this.Controls.Add(this.doubleBufferPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ch1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form3_Load);
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DoubleBufferPanel doubleBufferPanel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button cmdImage;
        private System.Windows.Forms.Button cmdWord;
        private System.Windows.Forms.Button cmdSelect;
        private System.Windows.Forms.Button button1;
        private DoubleBufferPanel doubleBufferPanel3;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button cmdCopy;




    }
}