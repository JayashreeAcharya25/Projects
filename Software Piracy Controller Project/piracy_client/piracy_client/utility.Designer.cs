namespace piracy_client
{
    partial class utility
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(utility));
            this.panelMdi = new System.Windows.Forms.Panel();
            this.panelUtility = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnEMI = new System.Windows.Forms.Button();
            this.btnCal = new System.Windows.Forms.Button();
            this.btnNotepad = new System.Windows.Forms.Button();
            this.panelMdi.SuspendLayout();
            this.panelUtility.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMdi
            // 
            this.panelMdi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelMdi.BackgroundImage")));
            this.panelMdi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelMdi.Controls.Add(this.panelUtility);
            this.panelMdi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMdi.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelMdi.Location = new System.Drawing.Point(0, 0);
            this.panelMdi.Margin = new System.Windows.Forms.Padding(4);
            this.panelMdi.Name = "panelMdi";
            this.panelMdi.Size = new System.Drawing.Size(814, 504);
            this.panelMdi.TabIndex = 3;
            // 
            // panelUtility
            // 
            this.panelUtility.BackColor = System.Drawing.Color.Black;
            this.panelUtility.Controls.Add(this.pictureBox2);
            this.panelUtility.Controls.Add(this.btnEMI);
            this.panelUtility.Controls.Add(this.btnCal);
            this.panelUtility.Controls.Add(this.btnNotepad);
            this.panelUtility.Location = new System.Drawing.Point(0, 0);
            this.panelUtility.Name = "panelUtility";
            this.panelUtility.Size = new System.Drawing.Size(836, 57);
            this.panelUtility.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Red;
            this.pictureBox2.Location = new System.Drawing.Point(0, 47);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(164, 10);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // btnEMI
            // 
            this.btnEMI.FlatAppearance.BorderSize = 0;
            this.btnEMI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEMI.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEMI.ForeColor = System.Drawing.Color.White;
            this.btnEMI.Location = new System.Drawing.Point(344, 0);
            this.btnEMI.Margin = new System.Windows.Forms.Padding(4);
            this.btnEMI.Name = "btnEMI";
            this.btnEMI.Size = new System.Drawing.Size(177, 57);
            this.btnEMI.TabIndex = 1;
            this.btnEMI.Text = "EMI Calculation";
            this.btnEMI.UseVisualStyleBackColor = true;
            this.btnEMI.Click += new System.EventHandler(this.btnEMI_Click);
            // 
            // btnCal
            // 
            this.btnCal.BackColor = System.Drawing.Color.Black;
            this.btnCal.FlatAppearance.BorderSize = 0;
            this.btnCal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCal.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCal.ForeColor = System.Drawing.Color.White;
            this.btnCal.Location = new System.Drawing.Point(0, -3);
            this.btnCal.Margin = new System.Windows.Forms.Padding(4);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(164, 57);
            this.btnCal.TabIndex = 1;
            this.btnCal.Text = "Calculator";
            this.btnCal.UseVisualStyleBackColor = false;
            this.btnCal.Click += new System.EventHandler(this.btnCal_Click);
            // 
            // btnNotepad
            // 
            this.btnNotepad.FlatAppearance.BorderSize = 0;
            this.btnNotepad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotepad.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotepad.ForeColor = System.Drawing.Color.White;
            this.btnNotepad.Location = new System.Drawing.Point(166, 4);
            this.btnNotepad.Margin = new System.Windows.Forms.Padding(4);
            this.btnNotepad.Name = "btnNotepad";
            this.btnNotepad.Size = new System.Drawing.Size(159, 53);
            this.btnNotepad.TabIndex = 2;
            this.btnNotepad.Text = "Notepad";
            this.btnNotepad.UseVisualStyleBackColor = true;
            this.btnNotepad.Click += new System.EventHandler(this.btnNotepad_Click);
            // 
            // utility
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 504);
            this.ControlBox = false;
            this.Controls.Add(this.panelMdi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "utility";
            this.Text = "utility";
            this.panelMdi.ResumeLayout(false);
            this.panelUtility.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMdi;
        private System.Windows.Forms.Panel panelUtility;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnEMI;
        private System.Windows.Forms.Button btnCal;
        private System.Windows.Forms.Button btnNotepad;
    }
}