namespace piracy
{
    partial class master
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
            this.panelMaster = new piracy.DoubleBufferPanel();
            this.panelbuttons = new System.Windows.Forms.Panel();
            this.btnBank = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.panelMaster.SuspendLayout();
            this.panelbuttons.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMaster
            // 
            this.panelMaster.BackgroundImage = global::piracy.Properties.Resources.wp_image_144587393;
            this.panelMaster.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelMaster.Controls.Add(this.panelbuttons);
            this.panelMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMaster.Location = new System.Drawing.Point(0, 0);
            this.panelMaster.Name = "panelMaster";
            this.panelMaster.Size = new System.Drawing.Size(1086, 608);
            this.panelMaster.TabIndex = 2;
            // 
            // panelbuttons
            // 
            this.panelbuttons.BackColor = System.Drawing.Color.Black;
            this.panelbuttons.Controls.Add(this.btnBank);
            this.panelbuttons.Controls.Add(this.btnProduct);
            this.panelbuttons.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelbuttons.Location = new System.Drawing.Point(0, 0);
            this.panelbuttons.Name = "panelbuttons";
            this.panelbuttons.Size = new System.Drawing.Size(1086, 54);
            this.panelbuttons.TabIndex = 2;
            // 
            // btnBank
            // 
            this.btnBank.BackColor = System.Drawing.Color.Black;
            this.btnBank.FlatAppearance.BorderSize = 0;
            this.btnBank.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBank.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBank.ForeColor = System.Drawing.Color.White;
            this.btnBank.Location = new System.Drawing.Point(185, 0);
            this.btnBank.Name = "btnBank";
            this.btnBank.Size = new System.Drawing.Size(193, 54);
            this.btnBank.TabIndex = 4;
            this.btnBank.Text = "BANK";
            this.btnBank.UseVisualStyleBackColor = true;
            this.btnBank.Click += new System.EventHandler(this.btnBank_Click_1);
            // 
            // btnProduct
            // 
            this.btnProduct.BackColor = System.Drawing.Color.Black;
            this.btnProduct.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnProduct.FlatAppearance.BorderSize = 0;
            this.btnProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProduct.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduct.ForeColor = System.Drawing.Color.White;
            this.btnProduct.Location = new System.Drawing.Point(3, 0);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(193, 54);
            this.btnProduct.TabIndex = 3;
            this.btnProduct.Text = "PRODUCT";
            this.btnProduct.UseVisualStyleBackColor = true;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click_1);
            // 
            // master
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1086, 608);
            this.ControlBox = false;
            this.Controls.Add(this.panelMaster);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "master";
            this.Text = "design";
            this.panelMaster.ResumeLayout(false);
            this.panelbuttons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DoubleBufferPanel panelMaster;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Button btnBank;
        private System.Windows.Forms.Panel panelbuttons;

    }
}