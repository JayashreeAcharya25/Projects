namespace piracy_client
{
    partial class Serial_key
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Serial_key));
            this.txtserial = new System.Windows.Forms.TextBox();
            this.btnsub = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnbuy = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtserial
            // 
            this.txtserial.Location = new System.Drawing.Point(504, 393);
            this.txtserial.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtserial.Name = "txtserial";
            this.txtserial.PasswordChar = 'x';
            this.txtserial.Size = new System.Drawing.Size(345, 22);
            this.txtserial.TabIndex = 0;
            // 
            // btnsub
            // 
            this.btnsub.Location = new System.Drawing.Point(504, 484);
            this.btnsub.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnsub.Name = "btnsub";
            this.btnsub.Size = new System.Drawing.Size(149, 47);
            this.btnsub.TabIndex = 1;
            this.btnsub.Text = "Submit";
            this.btnsub.UseVisualStyleBackColor = true;
            this.btnsub.Click += new System.EventHandler(this.btnsub_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(601, 564);
            this.btnclear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(148, 39);
            this.btnclear.TabIndex = 2;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnbuy
            // 
            this.btnbuy.Location = new System.Drawing.Point(696, 484);
            this.btnbuy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnbuy.Name = "btnbuy";
            this.btnbuy.Size = new System.Drawing.Size(155, 47);
            this.btnbuy.TabIndex = 4;
            this.btnbuy.Text = "Buy Now";
            this.btnbuy.UseVisualStyleBackColor = true;
            this.btnbuy.Click += new System.EventHandler(this.btnbuy_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(479, 310);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 56);
            this.label1.TabIndex = 5;
            this.label1.Text = "Enter the Serial key";
            // 
            // Serial_key
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1417, 783);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnbuy);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnsub);
            this.Controls.Add(this.txtserial);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Serial_key";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtserial;
        private System.Windows.Forms.Button btnsub;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnbuy;
        private System.Windows.Forms.Label label1;
    }
}