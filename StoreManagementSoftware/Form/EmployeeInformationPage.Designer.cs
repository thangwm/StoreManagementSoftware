namespace StoreManagementSoftware
{
    partial class EmployeeInformationPage
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
            this.grbemployeeinformation = new System.Windows.Forms.GroupBox();
            this.lbvnd = new System.Windows.Forms.Label();
            this.lbimage = new System.Windows.Forms.Label();
            this.btaddptb = new System.Windows.Forms.Button();
            this.txtdateofbirth = new System.Windows.Forms.DateTimePicker();
            this.txtsalary = new System.Windows.Forms.ComboBox();
            this.txtposition = new System.Windows.Forms.ComboBox();
            this.txtgender = new System.Windows.Forms.ComboBox();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.txtfullname = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.lbemail = new System.Windows.Forms.Label();
            this.ptbemployee = new System.Windows.Forms.PictureBox();
            this.lbsalary = new System.Windows.Forms.Label();
            this.lbposition = new System.Windows.Forms.Label();
            this.lbaddress = new System.Windows.Forms.Label();
            this.lbdateofbirth = new System.Windows.Forms.Label();
            this.lbphone = new System.Windows.Forms.Label();
            this.lbgender = new System.Windows.Forms.Label();
            this.lbfullname = new System.Windows.Forms.Label();
            this.lbid = new System.Windows.Forms.Label();
            this.grbfunction = new System.Windows.Forms.GroupBox();
            this.btdelete = new System.Windows.Forms.Button();
            this.btupdate = new System.Windows.Forms.Button();
            this.btadd = new System.Windows.Forms.Button();
            this.grblistofemployee = new System.Windows.Forms.GroupBox();
            this.dataemployee = new System.Windows.Forms.DataGridView();
            this.btreset = new System.Windows.Forms.Button();
            this.btsearch = new System.Windows.Forms.Button();
            this.txtfind = new System.Windows.Forms.TextBox();
            this.lbfind = new System.Windows.Forms.Label();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.btrefresh = new System.Windows.Forms.Button();
            this.grbemployeeinformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbemployee)).BeginInit();
            this.grbfunction.SuspendLayout();
            this.grblistofemployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataemployee)).BeginInit();
            this.SuspendLayout();
            // 
            // grbemployeeinformation
            // 
            this.grbemployeeinformation.Controls.Add(this.lbvnd);
            this.grbemployeeinformation.Controls.Add(this.lbimage);
            this.grbemployeeinformation.Controls.Add(this.btaddptb);
            this.grbemployeeinformation.Controls.Add(this.txtdateofbirth);
            this.grbemployeeinformation.Controls.Add(this.txtsalary);
            this.grbemployeeinformation.Controls.Add(this.txtposition);
            this.grbemployeeinformation.Controls.Add(this.txtgender);
            this.grbemployeeinformation.Controls.Add(this.txtphone);
            this.grbemployeeinformation.Controls.Add(this.txtemail);
            this.grbemployeeinformation.Controls.Add(this.txtaddress);
            this.grbemployeeinformation.Controls.Add(this.txtfullname);
            this.grbemployeeinformation.Controls.Add(this.txtid);
            this.grbemployeeinformation.Controls.Add(this.lbemail);
            this.grbemployeeinformation.Controls.Add(this.ptbemployee);
            this.grbemployeeinformation.Controls.Add(this.lbsalary);
            this.grbemployeeinformation.Controls.Add(this.lbposition);
            this.grbemployeeinformation.Controls.Add(this.lbaddress);
            this.grbemployeeinformation.Controls.Add(this.lbdateofbirth);
            this.grbemployeeinformation.Controls.Add(this.lbphone);
            this.grbemployeeinformation.Controls.Add(this.lbgender);
            this.grbemployeeinformation.Controls.Add(this.lbfullname);
            this.grbemployeeinformation.Controls.Add(this.lbid);
            this.grbemployeeinformation.Location = new System.Drawing.Point(0, 0);
            this.grbemployeeinformation.Name = "grbemployeeinformation";
            this.grbemployeeinformation.Size = new System.Drawing.Size(376, 550);
            this.grbemployeeinformation.TabIndex = 0;
            this.grbemployeeinformation.TabStop = false;
            this.grbemployeeinformation.Text = "Employee Information";
            // 
            // lbvnd
            // 
            this.lbvnd.AutoSize = true;
            this.lbvnd.Location = new System.Drawing.Point(180, 450);
            this.lbvnd.Name = "lbvnd";
            this.lbvnd.Size = new System.Drawing.Size(36, 16);
            this.lbvnd.TabIndex = 22;
            this.lbvnd.Text = "VND";
            // 
            // lbimage
            // 
            this.lbimage.AutoSize = true;
            this.lbimage.Location = new System.Drawing.Point(12, 500);
            this.lbimage.Name = "lbimage";
            this.lbimage.Size = new System.Drawing.Size(48, 16);
            this.lbimage.TabIndex = 21;
            this.lbimage.Text = "Image:";
            // 
            // btaddptb
            // 
            this.btaddptb.Location = new System.Drawing.Point(75, 493);
            this.btaddptb.Name = "btaddptb";
            this.btaddptb.Size = new System.Drawing.Size(100, 23);
            this.btaddptb.TabIndex = 20;
            this.btaddptb.Text = "Add Picture";
            this.btaddptb.UseVisualStyleBackColor = true;
            this.btaddptb.Click += new System.EventHandler(this.btaddptb_Click);
            // 
            // txtdateofbirth
            // 
            this.txtdateofbirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtdateofbirth.Location = new System.Drawing.Point(100, 195);
            this.txtdateofbirth.Name = "txtdateofbirth";
            this.txtdateofbirth.Size = new System.Drawing.Size(225, 22);
            this.txtdateofbirth.TabIndex = 17;
            // 
            // txtsalary
            // 
            this.txtsalary.FormattingEnabled = true;
            this.txtsalary.Items.AddRange(new object[] {
            "5000000",
            "10000000"});
            this.txtsalary.Location = new System.Drawing.Point(75, 442);
            this.txtsalary.Name = "txtsalary";
            this.txtsalary.Size = new System.Drawing.Size(100, 24);
            this.txtsalary.TabIndex = 16;
            // 
            // txtposition
            // 
            this.txtposition.FormattingEnabled = true;
            this.txtposition.Items.AddRange(new object[] {
            "Staff",
            "Management Staff"});
            this.txtposition.Location = new System.Drawing.Point(75, 392);
            this.txtposition.Name = "txtposition";
            this.txtposition.Size = new System.Drawing.Size(125, 24);
            this.txtposition.TabIndex = 15;
            // 
            // txtgender
            // 
            this.txtgender.FormattingEnabled = true;
            this.txtgender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.txtgender.Location = new System.Drawing.Point(75, 142);
            this.txtgender.Name = "txtgender";
            this.txtgender.Size = new System.Drawing.Size(125, 24);
            this.txtgender.TabIndex = 14;
            // 
            // txtphone
            // 
            this.txtphone.Location = new System.Drawing.Point(75, 344);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(125, 22);
            this.txtphone.TabIndex = 13;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(75, 294);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(250, 22);
            this.txtemail.TabIndex = 12;
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(75, 244);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(250, 22);
            this.txtaddress.TabIndex = 11;
            // 
            // txtfullname
            // 
            this.txtfullname.Location = new System.Drawing.Point(75, 94);
            this.txtfullname.Name = "txtfullname";
            this.txtfullname.Size = new System.Drawing.Size(250, 22);
            this.txtfullname.TabIndex = 10;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(75, 44);
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(125, 22);
            this.txtid.TabIndex = 9;
            // 
            // lbemail
            // 
            this.lbemail.AutoSize = true;
            this.lbemail.Location = new System.Drawing.Point(12, 300);
            this.lbemail.Name = "lbemail";
            this.lbemail.Size = new System.Drawing.Size(44, 16);
            this.lbemail.TabIndex = 8;
            this.lbemail.Text = "Email:";
            // 
            // ptbemployee
            // 
            this.ptbemployee.Image = global::StoreManagementSoftware.Properties.Resources._2;
            this.ptbemployee.Location = new System.Drawing.Point(220, 344);
            this.ptbemployee.Name = "ptbemployee";
            this.ptbemployee.Size = new System.Drawing.Size(150, 200);
            this.ptbemployee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbemployee.TabIndex = 7;
            this.ptbemployee.TabStop = false;
            this.ptbemployee.Click += new System.EventHandler(this.ptbemployee_Click);
            // 
            // lbsalary
            // 
            this.lbsalary.AutoSize = true;
            this.lbsalary.Location = new System.Drawing.Point(12, 450);
            this.lbsalary.Name = "lbsalary";
            this.lbsalary.Size = new System.Drawing.Size(49, 16);
            this.lbsalary.TabIndex = 6;
            this.lbsalary.Text = "Salary:";
            // 
            // lbposition
            // 
            this.lbposition.AutoSize = true;
            this.lbposition.Location = new System.Drawing.Point(12, 400);
            this.lbposition.Name = "lbposition";
            this.lbposition.Size = new System.Drawing.Size(58, 16);
            this.lbposition.TabIndex = 5;
            this.lbposition.Text = "Position:";
            // 
            // lbaddress
            // 
            this.lbaddress.AutoSize = true;
            this.lbaddress.Location = new System.Drawing.Point(12, 250);
            this.lbaddress.Name = "lbaddress";
            this.lbaddress.Size = new System.Drawing.Size(61, 16);
            this.lbaddress.TabIndex = 4;
            this.lbaddress.Text = "Address:";
            // 
            // lbdateofbirth
            // 
            this.lbdateofbirth.AutoSize = true;
            this.lbdateofbirth.Location = new System.Drawing.Point(12, 200);
            this.lbdateofbirth.Name = "lbdateofbirth";
            this.lbdateofbirth.Size = new System.Drawing.Size(81, 16);
            this.lbdateofbirth.TabIndex = 3;
            this.lbdateofbirth.Text = "Date of birth:";
            // 
            // lbphone
            // 
            this.lbphone.AutoSize = true;
            this.lbphone.Location = new System.Drawing.Point(12, 350);
            this.lbphone.Name = "lbphone";
            this.lbphone.Size = new System.Drawing.Size(49, 16);
            this.lbphone.TabIndex = 3;
            this.lbphone.Text = "Phone:";
            // 
            // lbgender
            // 
            this.lbgender.AutoSize = true;
            this.lbgender.Location = new System.Drawing.Point(12, 150);
            this.lbgender.Name = "lbgender";
            this.lbgender.Size = new System.Drawing.Size(55, 16);
            this.lbgender.TabIndex = 2;
            this.lbgender.Text = "Gender:";
            // 
            // lbfullname
            // 
            this.lbfullname.AutoSize = true;
            this.lbfullname.Location = new System.Drawing.Point(12, 100);
            this.lbfullname.Name = "lbfullname";
            this.lbfullname.Size = new System.Drawing.Size(65, 16);
            this.lbfullname.TabIndex = 1;
            this.lbfullname.Text = "Fullname:";
            // 
            // lbid
            // 
            this.lbid.AutoSize = true;
            this.lbid.Location = new System.Drawing.Point(12, 50);
            this.lbid.Name = "lbid";
            this.lbid.Size = new System.Drawing.Size(23, 16);
            this.lbid.TabIndex = 0;
            this.lbid.Text = "ID:";
            // 
            // grbfunction
            // 
            this.grbfunction.Controls.Add(this.btrefresh);
            this.grbfunction.Controls.Add(this.btdelete);
            this.grbfunction.Controls.Add(this.btupdate);
            this.grbfunction.Controls.Add(this.btadd);
            this.grbfunction.Location = new System.Drawing.Point(0, 553);
            this.grbfunction.Name = "grbfunction";
            this.grbfunction.Size = new System.Drawing.Size(376, 100);
            this.grbfunction.TabIndex = 1;
            this.grbfunction.TabStop = false;
            this.grbfunction.Text = "Function";
            // 
            // btdelete
            // 
            this.btdelete.Location = new System.Drawing.Point(200, 50);
            this.btdelete.Name = "btdelete";
            this.btdelete.Size = new System.Drawing.Size(75, 23);
            this.btdelete.TabIndex = 19;
            this.btdelete.Text = "Delete";
            this.btdelete.UseVisualStyleBackColor = true;
            this.btdelete.Click += new System.EventHandler(this.btdelete_Click);
            // 
            // btupdate
            // 
            this.btupdate.Location = new System.Drawing.Point(100, 50);
            this.btupdate.Name = "btupdate";
            this.btupdate.Size = new System.Drawing.Size(75, 23);
            this.btupdate.TabIndex = 18;
            this.btupdate.Text = "Update";
            this.btupdate.UseVisualStyleBackColor = true;
            this.btupdate.Click += new System.EventHandler(this.btupdate_Click);
            // 
            // btadd
            // 
            this.btadd.Location = new System.Drawing.Point(12, 50);
            this.btadd.Name = "btadd";
            this.btadd.Size = new System.Drawing.Size(75, 23);
            this.btadd.TabIndex = 17;
            this.btadd.Text = "Add";
            this.btadd.UseVisualStyleBackColor = true;
            this.btadd.Click += new System.EventHandler(this.btadd_Click);
            // 
            // grblistofemployee
            // 
            this.grblistofemployee.Controls.Add(this.dataemployee);
            this.grblistofemployee.Controls.Add(this.btreset);
            this.grblistofemployee.Controls.Add(this.btsearch);
            this.grblistofemployee.Controls.Add(this.txtfind);
            this.grblistofemployee.Controls.Add(this.lbfind);
            this.grblistofemployee.Dock = System.Windows.Forms.DockStyle.Right;
            this.grblistofemployee.Location = new System.Drawing.Point(382, 0);
            this.grblistofemployee.Name = "grblistofemployee";
            this.grblistofemployee.Size = new System.Drawing.Size(900, 653);
            this.grblistofemployee.TabIndex = 2;
            this.grblistofemployee.TabStop = false;
            this.grblistofemployee.Text = "List Of Employee";
            // 
            // dataemployee
            // 
            this.dataemployee.AllowUserToAddRows = false;
            this.dataemployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataemployee.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataemployee.Location = new System.Drawing.Point(3, 100);
            this.dataemployee.Name = "dataemployee";
            this.dataemployee.RowHeadersWidth = 51;
            this.dataemployee.RowTemplate.Height = 24;
            this.dataemployee.Size = new System.Drawing.Size(894, 550);
            this.dataemployee.TabIndex = 17;
            this.dataemployee.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataemployee_CellContentClick);
            // 
            // btreset
            // 
            this.btreset.Location = new System.Drawing.Point(450, 43);
            this.btreset.Name = "btreset";
            this.btreset.Size = new System.Drawing.Size(75, 23);
            this.btreset.TabIndex = 16;
            this.btreset.Text = "Reset";
            this.btreset.UseVisualStyleBackColor = true;
            this.btreset.Click += new System.EventHandler(this.btreset_Click);
            // 
            // btsearch
            // 
            this.btsearch.Location = new System.Drawing.Point(350, 44);
            this.btsearch.Name = "btsearch";
            this.btsearch.Size = new System.Drawing.Size(75, 23);
            this.btsearch.TabIndex = 15;
            this.btsearch.Text = "Search";
            this.btsearch.UseVisualStyleBackColor = true;
            this.btsearch.Click += new System.EventHandler(this.btsearch_Click);
            // 
            // txtfind
            // 
            this.txtfind.Location = new System.Drawing.Point(75, 44);
            this.txtfind.Name = "txtfind";
            this.txtfind.Size = new System.Drawing.Size(250, 22);
            this.txtfind.TabIndex = 14;
            // 
            // lbfind
            // 
            this.lbfind.AutoSize = true;
            this.lbfind.Location = new System.Drawing.Point(12, 50);
            this.lbfind.Name = "lbfind";
            this.lbfind.Size = new System.Drawing.Size(36, 16);
            this.lbfind.TabIndex = 9;
            this.lbfind.Text = "Find:";
            // 
            // ofd
            // 
            this.ofd.FileName = "ofd";
            // 
            // btrefresh
            // 
            this.btrefresh.Location = new System.Drawing.Point(300, 50);
            this.btrefresh.Name = "btrefresh";
            this.btrefresh.Size = new System.Drawing.Size(75, 23);
            this.btrefresh.TabIndex = 20;
            this.btrefresh.Text = "Refresh";
            this.btrefresh.UseVisualStyleBackColor = true;
            this.btrefresh.Click += new System.EventHandler(this.btrefresh_Click);
            // 
            // EmployeeInformationPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 653);
            this.Controls.Add(this.grblistofemployee);
            this.Controls.Add(this.grbfunction);
            this.Controls.Add(this.grbemployeeinformation);
            this.Name = "EmployeeInformationPage";
            this.Text = "EmployeeInformationPage";
            this.Load += new System.EventHandler(this.EmployeeInformationPage_Load);
            this.grbemployeeinformation.ResumeLayout(false);
            this.grbemployeeinformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbemployee)).EndInit();
            this.grbfunction.ResumeLayout(false);
            this.grblistofemployee.ResumeLayout(false);
            this.grblistofemployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataemployee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbemployeeinformation;
        private System.Windows.Forms.GroupBox grbfunction;
        private System.Windows.Forms.GroupBox grblistofemployee;
        private System.Windows.Forms.Label lbfullname;
        private System.Windows.Forms.Label lbid;
        private System.Windows.Forms.Label lbaddress;
        private System.Windows.Forms.Label lbdateofbirth;
        private System.Windows.Forms.Label lbphone;
        private System.Windows.Forms.Label lbgender;
        private System.Windows.Forms.Label lbsalary;
        private System.Windows.Forms.Label lbposition;
        private System.Windows.Forms.PictureBox ptbemployee;
        private System.Windows.Forms.Label lbemail;
        private System.Windows.Forms.ComboBox txtsalary;
        private System.Windows.Forms.ComboBox txtposition;
        private System.Windows.Forms.ComboBox txtgender;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.TextBox txtfullname;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtfind;
        private System.Windows.Forms.Label lbfind;
        private System.Windows.Forms.Button btaddptb;
        private System.Windows.Forms.DateTimePicker txtdateofbirth;
        private System.Windows.Forms.Button btdelete;
        private System.Windows.Forms.Button btupdate;
        private System.Windows.Forms.Button btadd;
        private System.Windows.Forms.Button btreset;
        private System.Windows.Forms.Button btsearch;
        private System.Windows.Forms.Label lbimage;
        private System.Windows.Forms.Label lbvnd;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.DataGridView dataemployee;
        private System.Windows.Forms.Button btrefresh;
    }
}