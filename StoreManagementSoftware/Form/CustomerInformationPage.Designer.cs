namespace StoreManagementSoftware
{
    partial class CustomerInformationPage
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
            this.btdelete = new System.Windows.Forms.Button();
            this.lbimage = new System.Windows.Forms.Label();
            this.btaddptb = new System.Windows.Forms.Button();
            this.txtdateofbirth = new System.Windows.Forms.DateTimePicker();
            this.txtmember = new System.Windows.Forms.ComboBox();
            this.txtgender = new System.Windows.Forms.ComboBox();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.btadd = new System.Windows.Forms.Button();
            this.grblistofcustomer = new System.Windows.Forms.GroupBox();
            this.btreset = new System.Windows.Forms.Button();
            this.btsearch = new System.Windows.Forms.Button();
            this.txtfind = new System.Windows.Forms.TextBox();
            this.lbfind = new System.Windows.Forms.Label();
            this.datacustomer = new System.Windows.Forms.DataGridView();
            this.txtfullname = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.lbemail = new System.Windows.Forms.Label();
            this.ptbcustomer = new System.Windows.Forms.PictureBox();
            this.btupdate = new System.Windows.Forms.Button();
            this.lbmember = new System.Windows.Forms.Label();
            this.lbaddress = new System.Windows.Forms.Label();
            this.lbdateofbirth = new System.Windows.Forms.Label();
            this.lbphone = new System.Windows.Forms.Label();
            this.lbgender = new System.Windows.Forms.Label();
            this.lbfullname = new System.Windows.Forms.Label();
            this.lbid = new System.Windows.Forms.Label();
            this.grbfunction = new System.Windows.Forms.GroupBox();
            this.grbcustomerinformation = new System.Windows.Forms.GroupBox();
            this.btrefresh = new System.Windows.Forms.Button();
            this.grblistofcustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datacustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbcustomer)).BeginInit();
            this.grbfunction.SuspendLayout();
            this.grbcustomerinformation.SuspendLayout();
            this.SuspendLayout();
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
            // lbimage
            // 
            this.lbimage.AutoSize = true;
            this.lbimage.Location = new System.Drawing.Point(12, 450);
            this.lbimage.Name = "lbimage";
            this.lbimage.Size = new System.Drawing.Size(48, 16);
            this.lbimage.TabIndex = 21;
            this.lbimage.Text = "Image:";
            // 
            // btaddptb
            // 
            this.btaddptb.Location = new System.Drawing.Point(75, 443);
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
            // txtmember
            // 
            this.txtmember.FormattingEnabled = true;
            this.txtmember.Items.AddRange(new object[] {
            "Normal",
            "Vip"});
            this.txtmember.Location = new System.Drawing.Point(75, 392);
            this.txtmember.Name = "txtmember";
            this.txtmember.Size = new System.Drawing.Size(125, 24);
            this.txtmember.TabIndex = 15;
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
            // grblistofcustomer
            // 
            this.grblistofcustomer.Controls.Add(this.btreset);
            this.grblistofcustomer.Controls.Add(this.btsearch);
            this.grblistofcustomer.Controls.Add(this.txtfind);
            this.grblistofcustomer.Controls.Add(this.lbfind);
            this.grblistofcustomer.Controls.Add(this.datacustomer);
            this.grblistofcustomer.Dock = System.Windows.Forms.DockStyle.Right;
            this.grblistofcustomer.Location = new System.Drawing.Point(382, 0);
            this.grblistofcustomer.Name = "grblistofcustomer";
            this.grblistofcustomer.Size = new System.Drawing.Size(900, 653);
            this.grblistofcustomer.TabIndex = 5;
            this.grblistofcustomer.TabStop = false;
            this.grblistofcustomer.Text = "List Of Customer";
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
            // datacustomer
            // 
            this.datacustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datacustomer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.datacustomer.Location = new System.Drawing.Point(3, 100);
            this.datacustomer.Name = "datacustomer";
            this.datacustomer.RowHeadersWidth = 51;
            this.datacustomer.RowTemplate.Height = 24;
            this.datacustomer.Size = new System.Drawing.Size(894, 550);
            this.datacustomer.TabIndex = 0;
            this.datacustomer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datacustomer_CellContentClick);
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
            // ptbcustomer
            // 
            this.ptbcustomer.Image = global::StoreManagementSoftware.Properties.Resources._1;
            this.ptbcustomer.Location = new System.Drawing.Point(226, 344);
            this.ptbcustomer.Name = "ptbcustomer";
            this.ptbcustomer.Size = new System.Drawing.Size(150, 200);
            this.ptbcustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbcustomer.TabIndex = 7;
            this.ptbcustomer.TabStop = false;
            this.ptbcustomer.Click += new System.EventHandler(this.ptbcustomer_Click);
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
            // lbmember
            // 
            this.lbmember.AutoSize = true;
            this.lbmember.Location = new System.Drawing.Point(12, 400);
            this.lbmember.Name = "lbmember";
            this.lbmember.Size = new System.Drawing.Size(60, 16);
            this.lbmember.TabIndex = 5;
            this.lbmember.Text = "Member:";
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
            this.grbfunction.TabIndex = 4;
            this.grbfunction.TabStop = false;
            this.grbfunction.Text = "Function";
            // 
            // grbcustomerinformation
            // 
            this.grbcustomerinformation.Controls.Add(this.lbimage);
            this.grbcustomerinformation.Controls.Add(this.btaddptb);
            this.grbcustomerinformation.Controls.Add(this.txtdateofbirth);
            this.grbcustomerinformation.Controls.Add(this.txtmember);
            this.grbcustomerinformation.Controls.Add(this.txtgender);
            this.grbcustomerinformation.Controls.Add(this.txtphone);
            this.grbcustomerinformation.Controls.Add(this.txtemail);
            this.grbcustomerinformation.Controls.Add(this.txtaddress);
            this.grbcustomerinformation.Controls.Add(this.txtfullname);
            this.grbcustomerinformation.Controls.Add(this.txtid);
            this.grbcustomerinformation.Controls.Add(this.lbemail);
            this.grbcustomerinformation.Controls.Add(this.ptbcustomer);
            this.grbcustomerinformation.Controls.Add(this.lbmember);
            this.grbcustomerinformation.Controls.Add(this.lbaddress);
            this.grbcustomerinformation.Controls.Add(this.lbdateofbirth);
            this.grbcustomerinformation.Controls.Add(this.lbphone);
            this.grbcustomerinformation.Controls.Add(this.lbgender);
            this.grbcustomerinformation.Controls.Add(this.lbfullname);
            this.grbcustomerinformation.Controls.Add(this.lbid);
            this.grbcustomerinformation.Location = new System.Drawing.Point(0, 0);
            this.grbcustomerinformation.Name = "grbcustomerinformation";
            this.grbcustomerinformation.Size = new System.Drawing.Size(376, 550);
            this.grbcustomerinformation.TabIndex = 3;
            this.grbcustomerinformation.TabStop = false;
            this.grbcustomerinformation.Text = "Customer Information";
            // 
            // btrefresh
            // 
            this.btrefresh.Location = new System.Drawing.Point(300, 50);
            this.btrefresh.Name = "btrefresh";
            this.btrefresh.Size = new System.Drawing.Size(75, 23);
            this.btrefresh.TabIndex = 21;
            this.btrefresh.Text = "Refresh";
            this.btrefresh.UseVisualStyleBackColor = true;
            this.btrefresh.Click += new System.EventHandler(this.btrefresh_Click);
            // 
            // CustomerInformationPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 653);
            this.Controls.Add(this.grblistofcustomer);
            this.Controls.Add(this.grbfunction);
            this.Controls.Add(this.grbcustomerinformation);
            this.Name = "CustomerInformationPage";
            this.Text = "CustomerInformationPage";
            this.Load += new System.EventHandler(this.CustomerInformationPage_Load);
            this.grblistofcustomer.ResumeLayout(false);
            this.grblistofcustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datacustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbcustomer)).EndInit();
            this.grbfunction.ResumeLayout(false);
            this.grbcustomerinformation.ResumeLayout(false);
            this.grbcustomerinformation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btdelete;
        private System.Windows.Forms.Label lbimage;
        private System.Windows.Forms.Button btaddptb;
        private System.Windows.Forms.DateTimePicker txtdateofbirth;
        private System.Windows.Forms.ComboBox txtmember;
        private System.Windows.Forms.ComboBox txtgender;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.Button btadd;
        private System.Windows.Forms.GroupBox grblistofcustomer;
        private System.Windows.Forms.Button btreset;
        private System.Windows.Forms.Button btsearch;
        private System.Windows.Forms.TextBox txtfind;
        private System.Windows.Forms.Label lbfind;
        private System.Windows.Forms.DataGridView datacustomer;
        private System.Windows.Forms.TextBox txtfullname;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label lbemail;
        private System.Windows.Forms.PictureBox ptbcustomer;
        private System.Windows.Forms.Button btupdate;
        private System.Windows.Forms.Label lbmember;
        private System.Windows.Forms.Label lbaddress;
        private System.Windows.Forms.Label lbdateofbirth;
        private System.Windows.Forms.Label lbphone;
        private System.Windows.Forms.Label lbgender;
        private System.Windows.Forms.Label lbfullname;
        private System.Windows.Forms.Label lbid;
        private System.Windows.Forms.GroupBox grbfunction;
        private System.Windows.Forms.GroupBox grbcustomerinformation;
        private System.Windows.Forms.Button btrefresh;
    }
}