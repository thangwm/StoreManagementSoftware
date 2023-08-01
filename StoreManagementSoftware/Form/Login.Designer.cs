namespace StoreManagementSoftware
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
            this.ptblogin = new System.Windows.Forms.PictureBox();
            this.lblogin = new System.Windows.Forms.Label();
            this.lbusername = new System.Windows.Forms.Label();
            this.lbpassword = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.cbshowpassword = new System.Windows.Forms.CheckBox();
            this.btlogin = new System.Windows.Forms.Button();
            this.btexit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ptblogin)).BeginInit();
            this.SuspendLayout();
            // 
            // ptblogin
            // 
            this.ptblogin.Dock = System.Windows.Forms.DockStyle.Left;
            this.ptblogin.Image = global::StoreManagementSoftware.Properties.Resources._4;
            this.ptblogin.Location = new System.Drawing.Point(0, 0);
            this.ptblogin.Name = "ptblogin";
            this.ptblogin.Size = new System.Drawing.Size(400, 553);
            this.ptblogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptblogin.TabIndex = 0;
            this.ptblogin.TabStop = false;
            // 
            // lblogin
            // 
            this.lblogin.AutoSize = true;
            this.lblogin.Location = new System.Drawing.Point(552, 89);
            this.lblogin.Name = "lblogin";
            this.lblogin.Size = new System.Drawing.Size(47, 16);
            this.lblogin.TabIndex = 1;
            this.lblogin.Text = "LOGIN";
            // 
            // lbusername
            // 
            this.lbusername.AutoSize = true;
            this.lbusername.Location = new System.Drawing.Point(453, 158);
            this.lbusername.Name = "lbusername";
            this.lbusername.Size = new System.Drawing.Size(73, 16);
            this.lbusername.TabIndex = 2;
            this.lbusername.Text = "Username:";
            // 
            // lbpassword
            // 
            this.lbpassword.AutoSize = true;
            this.lbpassword.Location = new System.Drawing.Point(453, 235);
            this.lbpassword.Name = "lbpassword";
            this.lbpassword.Size = new System.Drawing.Size(70, 16);
            this.lbpassword.TabIndex = 3;
            this.lbpassword.Text = "Password:";
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(533, 151);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(200, 22);
            this.txtusername.TabIndex = 4;
            this.txtusername.Text = "thangwm";
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(533, 229);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '●';
            this.txtpassword.Size = new System.Drawing.Size(200, 22);
            this.txtpassword.TabIndex = 5;
            this.txtpassword.Text = "662003";
            // 
            // cbshowpassword
            // 
            this.cbshowpassword.AutoSize = true;
            this.cbshowpassword.Location = new System.Drawing.Point(533, 295);
            this.cbshowpassword.Name = "cbshowpassword";
            this.cbshowpassword.Size = new System.Drawing.Size(127, 20);
            this.cbshowpassword.TabIndex = 6;
            this.cbshowpassword.Text = "Show password.";
            this.cbshowpassword.UseVisualStyleBackColor = true;
            this.cbshowpassword.CheckedChanged += new System.EventHandler(this.cbshowpassword_CheckedChanged);
            // 
            // btlogin
            // 
            this.btlogin.Location = new System.Drawing.Point(456, 376);
            this.btlogin.Name = "btlogin";
            this.btlogin.Size = new System.Drawing.Size(75, 23);
            this.btlogin.TabIndex = 7;
            this.btlogin.Text = "Login";
            this.btlogin.UseVisualStyleBackColor = true;
            this.btlogin.Click += new System.EventHandler(this.btlogin_Click);
            // 
            // btexit
            // 
            this.btexit.Location = new System.Drawing.Point(658, 376);
            this.btexit.Name = "btexit";
            this.btexit.Size = new System.Drawing.Size(75, 23);
            this.btexit.TabIndex = 8;
            this.btexit.Text = "Exit";
            this.btexit.UseVisualStyleBackColor = true;
            this.btexit.Click += new System.EventHandler(this.btexit_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.btexit);
            this.Controls.Add(this.btlogin);
            this.Controls.Add(this.cbshowpassword);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.lbpassword);
            this.Controls.Add(this.lbusername);
            this.Controls.Add(this.lblogin);
            this.Controls.Add(this.ptblogin);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptblogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptblogin;
        private System.Windows.Forms.Label lblogin;
        private System.Windows.Forms.Label lbusername;
        private System.Windows.Forms.Label lbpassword;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.CheckBox cbshowpassword;
        private System.Windows.Forms.Button btlogin;
        private System.Windows.Forms.Button btexit;
    }
}