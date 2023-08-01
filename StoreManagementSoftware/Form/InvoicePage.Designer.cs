namespace StoreManagementSoftware
{
    partial class InvoicePage
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
            this.grblistofinvoicedetails = new System.Windows.Forms.GroupBox();
            this.txtdatefounded = new System.Windows.Forms.DateTimePicker();
            this.btprint = new System.Windows.Forms.Button();
            this.btinvoicedetails = new System.Windows.Forms.Button();
            this.lbdatefounded = new System.Windows.Forms.Label();
            this.lbvnd = new System.Windows.Forms.Label();
            this.txttotalprice = new System.Windows.Forms.TextBox();
            this.lbtotalprice = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.lbid = new System.Windows.Forms.Label();
            this.datainvoicedetails = new System.Windows.Forms.DataGridView();
            this.grblistofinvoice = new System.Windows.Forms.GroupBox();
            this.btreset = new System.Windows.Forms.Button();
            this.btsearch = new System.Windows.Forms.Button();
            this.txtfind = new System.Windows.Forms.TextBox();
            this.lbfind = new System.Windows.Forms.Label();
            this.datainvoice = new System.Windows.Forms.DataGridView();
            this.grblistofinvoicedetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datainvoicedetails)).BeginInit();
            this.grblistofinvoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datainvoice)).BeginInit();
            this.SuspendLayout();
            // 
            // grblistofinvoicedetails
            // 
            this.grblistofinvoicedetails.Controls.Add(this.txtdatefounded);
            this.grblistofinvoicedetails.Controls.Add(this.btprint);
            this.grblistofinvoicedetails.Controls.Add(this.btinvoicedetails);
            this.grblistofinvoicedetails.Controls.Add(this.lbdatefounded);
            this.grblistofinvoicedetails.Controls.Add(this.lbvnd);
            this.grblistofinvoicedetails.Controls.Add(this.txttotalprice);
            this.grblistofinvoicedetails.Controls.Add(this.lbtotalprice);
            this.grblistofinvoicedetails.Controls.Add(this.txtid);
            this.grblistofinvoicedetails.Controls.Add(this.lbid);
            this.grblistofinvoicedetails.Controls.Add(this.datainvoicedetails);
            this.grblistofinvoicedetails.Dock = System.Windows.Forms.DockStyle.Right;
            this.grblistofinvoicedetails.Location = new System.Drawing.Point(653, 0);
            this.grblistofinvoicedetails.Name = "grblistofinvoicedetails";
            this.grblistofinvoicedetails.Size = new System.Drawing.Size(629, 653);
            this.grblistofinvoicedetails.TabIndex = 20;
            this.grblistofinvoicedetails.TabStop = false;
            this.grblistofinvoicedetails.Text = "List Of Invoice Details";
            // 
            // txtdatefounded
            // 
            this.txtdatefounded.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtdatefounded.Location = new System.Drawing.Point(125, 144);
            this.txtdatefounded.Name = "txtdatefounded";
            this.txtdatefounded.Size = new System.Drawing.Size(225, 22);
            this.txtdatefounded.TabIndex = 58;
            // 
            // btprint
            // 
            this.btprint.Location = new System.Drawing.Point(400, 200);
            this.btprint.Name = "btprint";
            this.btprint.Size = new System.Drawing.Size(75, 23);
            this.btprint.TabIndex = 57;
            this.btprint.Text = "Print";
            this.btprint.UseVisualStyleBackColor = true;
            this.btprint.Click += new System.EventHandler(this.btprint_Click);
            // 
            // btinvoicedetails
            // 
            this.btinvoicedetails.Location = new System.Drawing.Point(125, 200);
            this.btinvoicedetails.Name = "btinvoicedetails";
            this.btinvoicedetails.Size = new System.Drawing.Size(125, 23);
            this.btinvoicedetails.TabIndex = 17;
            this.btinvoicedetails.Text = "Invoice Details";
            this.btinvoicedetails.UseVisualStyleBackColor = true;
            this.btinvoicedetails.Click += new System.EventHandler(this.btinvoicedetails_Click);
            // 
            // lbdatefounded
            // 
            this.lbdatefounded.AutoSize = true;
            this.lbdatefounded.Location = new System.Drawing.Point(12, 150);
            this.lbdatefounded.Name = "lbdatefounded";
            this.lbdatefounded.Size = new System.Drawing.Size(96, 16);
            this.lbdatefounded.TabIndex = 56;
            this.lbdatefounded.Text = "Date Founded:";
            // 
            // lbvnd
            // 
            this.lbvnd.AutoSize = true;
            this.lbvnd.Location = new System.Drawing.Point(230, 100);
            this.lbvnd.Name = "lbvnd";
            this.lbvnd.Size = new System.Drawing.Size(36, 16);
            this.lbvnd.TabIndex = 55;
            this.lbvnd.Text = "VND";
            // 
            // txttotalprice
            // 
            this.txttotalprice.Location = new System.Drawing.Point(125, 94);
            this.txttotalprice.Name = "txttotalprice";
            this.txttotalprice.Size = new System.Drawing.Size(100, 22);
            this.txttotalprice.TabIndex = 54;
            // 
            // lbtotalprice
            // 
            this.lbtotalprice.AutoSize = true;
            this.lbtotalprice.Location = new System.Drawing.Point(12, 100);
            this.lbtotalprice.Name = "lbtotalprice";
            this.lbtotalprice.Size = new System.Drawing.Size(74, 16);
            this.lbtotalprice.TabIndex = 53;
            this.lbtotalprice.Text = "Total price:";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(125, 43);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 22);
            this.txtid.TabIndex = 45;
            // 
            // lbid
            // 
            this.lbid.AutoSize = true;
            this.lbid.Location = new System.Drawing.Point(12, 49);
            this.lbid.Name = "lbid";
            this.lbid.Size = new System.Drawing.Size(23, 16);
            this.lbid.TabIndex = 44;
            this.lbid.Text = "ID:";
            // 
            // datainvoicedetails
            // 
            this.datainvoicedetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datainvoicedetails.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.datainvoicedetails.Location = new System.Drawing.Point(3, 300);
            this.datainvoicedetails.Name = "datainvoicedetails";
            this.datainvoicedetails.RowHeadersWidth = 51;
            this.datainvoicedetails.RowTemplate.Height = 24;
            this.datainvoicedetails.Size = new System.Drawing.Size(623, 350);
            this.datainvoicedetails.TabIndex = 0;
            // 
            // grblistofinvoice
            // 
            this.grblistofinvoice.Controls.Add(this.btreset);
            this.grblistofinvoice.Controls.Add(this.btsearch);
            this.grblistofinvoice.Controls.Add(this.txtfind);
            this.grblistofinvoice.Controls.Add(this.lbfind);
            this.grblistofinvoice.Controls.Add(this.datainvoice);
            this.grblistofinvoice.Dock = System.Windows.Forms.DockStyle.Left;
            this.grblistofinvoice.Location = new System.Drawing.Point(0, 0);
            this.grblistofinvoice.Name = "grblistofinvoice";
            this.grblistofinvoice.Size = new System.Drawing.Size(650, 653);
            this.grblistofinvoice.TabIndex = 21;
            this.grblistofinvoice.TabStop = false;
            this.grblistofinvoice.Text = "List Of Invoice";
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
            // datainvoice
            // 
            this.datainvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datainvoice.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.datainvoice.Location = new System.Drawing.Point(3, 100);
            this.datainvoice.Name = "datainvoice";
            this.datainvoice.RowHeadersWidth = 51;
            this.datainvoice.RowTemplate.Height = 24;
            this.datainvoice.Size = new System.Drawing.Size(644, 550);
            this.datainvoice.TabIndex = 0;
            this.datainvoice.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datainvoice_CellContentClick);
            // 
            // InvoicePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 653);
            this.Controls.Add(this.grblistofinvoice);
            this.Controls.Add(this.grblistofinvoicedetails);
            this.Name = "InvoicePage";
            this.Text = "InvoicePage";
            this.Load += new System.EventHandler(this.InvoicePage_Load);
            this.grblistofinvoicedetails.ResumeLayout(false);
            this.grblistofinvoicedetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datainvoicedetails)).EndInit();
            this.grblistofinvoice.ResumeLayout(false);
            this.grblistofinvoice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datainvoice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grblistofinvoicedetails;
        private System.Windows.Forms.DataGridView datainvoicedetails;
        private System.Windows.Forms.GroupBox grblistofinvoice;
        private System.Windows.Forms.Button btreset;
        private System.Windows.Forms.Button btsearch;
        private System.Windows.Forms.TextBox txtfind;
        private System.Windows.Forms.Label lbfind;
        private System.Windows.Forms.DataGridView datainvoice;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label lbid;
        private System.Windows.Forms.Label lbvnd;
        private System.Windows.Forms.TextBox txttotalprice;
        private System.Windows.Forms.Label lbtotalprice;
        private System.Windows.Forms.Label lbdatefounded;
        private System.Windows.Forms.Button btinvoicedetails;
        private System.Windows.Forms.Button btprint;
        private System.Windows.Forms.DateTimePicker txtdatefounded;
    }
}