namespace StoreManagementSoftware
{
    partial class HomePage
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
            this.components = new System.ComponentModel.Container();
            this.ptbview = new System.Windows.Forms.PictureBox();
            this.btleft = new System.Windows.Forms.Button();
            this.btright = new System.Windows.Forms.Button();
            this.time = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ptbview)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbview
            // 
            this.ptbview.Location = new System.Drawing.Point(0, 0);
            this.ptbview.Name = "ptbview";
            this.ptbview.Size = new System.Drawing.Size(1282, 653);
            this.ptbview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbview.TabIndex = 0;
            this.ptbview.TabStop = false;
            // 
            // btleft
            // 
            this.btleft.Location = new System.Drawing.Point(12, 296);
            this.btleft.Name = "btleft";
            this.btleft.Size = new System.Drawing.Size(30, 40);
            this.btleft.TabIndex = 1;
            this.btleft.Text = "<";
            this.btleft.UseVisualStyleBackColor = true;
            this.btleft.Click += new System.EventHandler(this.btleft_Click);
            // 
            // btright
            // 
            this.btright.Location = new System.Drawing.Point(1240, 296);
            this.btright.Name = "btright";
            this.btright.Size = new System.Drawing.Size(30, 40);
            this.btright.TabIndex = 2;
            this.btright.Text = ">";
            this.btright.UseVisualStyleBackColor = true;
            this.btright.Click += new System.EventHandler(this.btright_Click);
            // 
            // time
            // 
            this.time.Enabled = true;
            this.time.Interval = 2000;
            this.time.Tick += new System.EventHandler(this.time_Tick);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 653);
            this.Controls.Add(this.btright);
            this.Controls.Add(this.btleft);
            this.Controls.Add(this.ptbview);
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.Load += new System.EventHandler(this.HomePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbview;
        private System.Windows.Forms.Button btleft;
        private System.Windows.Forms.Button btright;
        private System.Windows.Forms.Timer time;
    }
}