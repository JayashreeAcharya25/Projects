namespace WindowsFormsApplication1
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmdLogin = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdPassword = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdUsername = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape2 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.cmdLogin);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cmdPassword);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmdUsername);
            this.panel1.Controls.Add(this.shapeContainer1);
            this.panel1.Location = new System.Drawing.Point(192, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(395, 409);
            this.panel1.TabIndex = 0;
            // 
            // cmdLogin
            // 
            this.cmdLogin.Activecolor = System.Drawing.Color.Silver;
            this.cmdLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdLogin.BackColor = System.Drawing.Color.Red;
            this.cmdLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdLogin.BorderRadius = 0;
            this.cmdLogin.ButtonText = "Login";
            this.cmdLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdLogin.DisabledColor = System.Drawing.Color.Gray;
            this.cmdLogin.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLogin.ForeColor = System.Drawing.Color.White;
            this.cmdLogin.Iconcolor = System.Drawing.Color.Transparent;
            this.cmdLogin.Iconimage = null;
            this.cmdLogin.Iconimage_right = null;
            this.cmdLogin.Iconimage_right_Selected = null;
            this.cmdLogin.Iconimage_Selected = null;
            this.cmdLogin.IconMarginLeft = 0;
            this.cmdLogin.IconMarginRight = 0;
            this.cmdLogin.IconRightVisible = true;
            this.cmdLogin.IconRightZoom = 0D;
            this.cmdLogin.IconVisible = true;
            this.cmdLogin.IconZoom = 90D;
            this.cmdLogin.IsTab = false;
            this.cmdLogin.Location = new System.Drawing.Point(111, 258);
            this.cmdLogin.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cmdLogin.Name = "cmdLogin";
            this.cmdLogin.Normalcolor = System.Drawing.Color.Red;
            this.cmdLogin.OnHovercolor = System.Drawing.Color.Gray;
            this.cmdLogin.OnHoverTextColor = System.Drawing.Color.White;
            this.cmdLogin.selected = false;
            this.cmdLogin.Size = new System.Drawing.Size(161, 66);
            this.cmdLogin.TabIndex = 5;
            this.cmdLogin.Text = "Login";
            this.cmdLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cmdLogin.Textcolor = System.Drawing.Color.White;
            this.cmdLogin.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLogin.Click += new System.EventHandler(this.cmdLogin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(151, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(42, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // cmdPassword
            // 
            this.cmdPassword.BorderColor = System.Drawing.Color.SeaGreen;
            this.cmdPassword.Location = new System.Drawing.Point(181, 176);
            this.cmdPassword.Name = "cmdPassword";
            this.cmdPassword.PasswordChar = '*';
            this.cmdPassword.Size = new System.Drawing.Size(170, 20);
            this.cmdPassword.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(42, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "User Name";
            // 
            // cmdUsername
            // 
            this.cmdUsername.BorderColor = System.Drawing.Color.SeaGreen;
            this.cmdUsername.Location = new System.Drawing.Point(181, 107);
            this.cmdUsername.Name = "cmdUsername";
            this.cmdUsername.Size = new System.Drawing.Size(170, 20);
            this.cmdUsername.TabIndex = 0;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape2,
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(395, 409);
            this.shapeContainer1.TabIndex = 2;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape2
            // 
            this.rectangleShape2.BorderColor = System.Drawing.Color.Red;
            this.rectangleShape2.Location = new System.Drawing.Point(176, 171);
            this.rectangleShape2.Name = "rectangleShape2";
            this.rectangleShape2.Size = new System.Drawing.Size(181, 31);
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.BorderColor = System.Drawing.Color.Red;
            this.rectangleShape1.Location = new System.Drawing.Point(176, 102);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(181, 31);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(786, 501);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox cmdUsername;
        private System.Windows.Forms.Label label1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private System.Windows.Forms.Label label2;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox cmdPassword;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape2;
        private Bunifu.Framework.UI.BunifuFlatButton cmdLogin;
        private System.Windows.Forms.Label label3;
    }
}