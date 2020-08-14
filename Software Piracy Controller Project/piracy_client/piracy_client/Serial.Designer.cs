namespace piracy_client
{
    partial class Serial
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelSerial = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnbuy = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnsub = new System.Windows.Forms.Button();
            this.txtserial = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panelSerial.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.Controls.Add(this.panelSerial);
            this.panel3.Location = new System.Drawing.Point(72, 69);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(552, 450);
            this.panel3.TabIndex = 4;
            // 
            // panelSerial
            // 
            this.panelSerial.BackColor = System.Drawing.Color.Gray;
            this.panelSerial.Controls.Add(this.panel2);
            this.panelSerial.Controls.Add(this.btnsub);
            this.panelSerial.Controls.Add(this.txtserial);
            this.panelSerial.Controls.Add(this.label1);
            this.panelSerial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSerial.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelSerial.ForeColor = System.Drawing.Color.White;
            this.panelSerial.Location = new System.Drawing.Point(0, 0);
            this.panelSerial.Margin = new System.Windows.Forms.Padding(4);
            this.panelSerial.Name = "panelSerial";
            this.panelSerial.Size = new System.Drawing.Size(552, 450);
            this.panelSerial.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.btnbuy);
            this.panel2.Controls.Add(this.btnclear);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 352);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(552, 98);
            this.panel2.TabIndex = 3;
            // 
            // btnbuy
            // 
            this.btnbuy.FlatAppearance.BorderSize = 0;
            this.btnbuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuy.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuy.ForeColor = System.Drawing.Color.Transparent;
            this.btnbuy.Location = new System.Drawing.Point(65, 30);
            this.btnbuy.Margin = new System.Windows.Forms.Padding(4);
            this.btnbuy.Name = "btnbuy";
            this.btnbuy.Size = new System.Drawing.Size(136, 44);
            this.btnbuy.TabIndex = 2;
            this.btnbuy.Text = "Buy Now";
            this.btnbuy.UseVisualStyleBackColor = true;
            this.btnbuy.Click += new System.EventHandler(this.btnbuy_Click);
            // 
            // btnclear
            // 
            this.btnclear.FlatAppearance.BorderSize = 0;
            this.btnclear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclear.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.ForeColor = System.Drawing.Color.Transparent;
            this.btnclear.Location = new System.Drawing.Point(312, 30);
            this.btnclear.Margin = new System.Windows.Forms.Padding(4);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(136, 44);
            this.btnclear.TabIndex = 2;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnsub
            // 
            this.btnsub.BackColor = System.Drawing.Color.DarkOrange;
            this.btnsub.FlatAppearance.BorderSize = 0;
            this.btnsub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsub.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsub.ForeColor = System.Drawing.Color.White;
            this.btnsub.Location = new System.Drawing.Point(162, 248);
            this.btnsub.Margin = new System.Windows.Forms.Padding(4);
            this.btnsub.Name = "btnsub";
            this.btnsub.Size = new System.Drawing.Size(197, 44);
            this.btnsub.TabIndex = 2;
            this.btnsub.Text = "Submit";
            this.btnsub.UseVisualStyleBackColor = false;
            this.btnsub.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtserial
            // 
            this.txtserial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtserial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtserial.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtserial.ForeColor = System.Drawing.Color.White;
            this.txtserial.Location = new System.Drawing.Point(107, 169);
            this.txtserial.Margin = new System.Windows.Forms.Padding(4);
            this.txtserial.Name = "txtserial";
            this.txtserial.PasswordChar = '*';
            this.txtserial.Size = new System.Drawing.Size(321, 25);
            this.txtserial.TabIndex = 1;
            this.txtserial.TextChanged += new System.EventHandler(this.txtserial_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(61, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the Serial Key";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Serial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::piracy_client.Properties.Resources.wp_image_1445873931;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(705, 603);
            this.ControlBox = false;
            this.Controls.Add(this.panel3);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Serial";
            this.Text = "Serial";
            this.panel3.ResumeLayout(false);
            this.panelSerial.ResumeLayout(false);
            this.panelSerial.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelSerial;
        private System.Windows.Forms.Button btnsub;
        private System.Windows.Forms.TextBox txtserial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnbuy;

    }
}