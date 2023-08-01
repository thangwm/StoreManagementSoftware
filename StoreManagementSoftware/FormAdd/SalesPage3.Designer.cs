namespace StoreManagementSoftware
{
    partial class SalesPage3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesPage3));
            this.grblistofproduct = new System.Windows.Forms.GroupBox();
            this.tcproduct = new System.Windows.Forms.TabControl();
            this.tpall = new System.Windows.Forms.TabPage();
            this.flpnall = new System.Windows.Forms.FlowLayoutPanel();
            this.tp1 = new System.Windows.Forms.TabPage();
            this.flpnproduct1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tp2 = new System.Windows.Forms.TabPage();
            this.flpnproduct2 = new System.Windows.Forms.FlowLayoutPanel();
            this.grblistofinvoicedetails = new System.Windows.Forms.GroupBox();
            this.txttotalprice = new System.Windows.Forms.TextBox();
            this.btprintbill = new System.Windows.Forms.Button();
            this.btpay = new System.Windows.Forms.Button();
            this.btdelete = new System.Windows.Forms.Button();
            this.lvproduct = new System.Windows.Forms.ListView();
            this.chid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chproductname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chunitprice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chquantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.printDocumentInvoice = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialogInvoice = new System.Windows.Forms.PrintPreviewDialog();
            this.grblistofproduct.SuspendLayout();
            this.tcproduct.SuspendLayout();
            this.tpall.SuspendLayout();
            this.tp1.SuspendLayout();
            this.tp2.SuspendLayout();
            this.grblistofinvoicedetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // grblistofproduct
            // 
            this.grblistofproduct.Controls.Add(this.tcproduct);
            this.grblistofproduct.Dock = System.Windows.Forms.DockStyle.Left;
            this.grblistofproduct.Location = new System.Drawing.Point(0, 0);
            this.grblistofproduct.Name = "grblistofproduct";
            this.grblistofproduct.Size = new System.Drawing.Size(650, 653);
            this.grblistofproduct.TabIndex = 1;
            this.grblistofproduct.TabStop = false;
            this.grblistofproduct.Text = "List Of Product";
            // 
            // tcproduct
            // 
            this.tcproduct.Controls.Add(this.tpall);
            this.tcproduct.Controls.Add(this.tp1);
            this.tcproduct.Controls.Add(this.tp2);
            this.tcproduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcproduct.Location = new System.Drawing.Point(3, 18);
            this.tcproduct.Name = "tcproduct";
            this.tcproduct.SelectedIndex = 0;
            this.tcproduct.Size = new System.Drawing.Size(644, 632);
            this.tcproduct.TabIndex = 1;
            // 
            // tpall
            // 
            this.tpall.Controls.Add(this.flpnall);
            this.tpall.Location = new System.Drawing.Point(4, 25);
            this.tpall.Name = "tpall";
            this.tpall.Padding = new System.Windows.Forms.Padding(3);
            this.tpall.Size = new System.Drawing.Size(636, 603);
            this.tpall.TabIndex = 0;
            this.tpall.Text = "All";
            this.tpall.UseVisualStyleBackColor = true;
            // 
            // flpnall
            // 
            this.flpnall.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpnall.Location = new System.Drawing.Point(3, 3);
            this.flpnall.Name = "flpnall";
            this.flpnall.Size = new System.Drawing.Size(630, 597);
            this.flpnall.TabIndex = 0;
            // 
            // tp1
            // 
            this.tp1.Controls.Add(this.flpnproduct1);
            this.tp1.Location = new System.Drawing.Point(4, 25);
            this.tp1.Name = "tp1";
            this.tp1.Padding = new System.Windows.Forms.Padding(3);
            this.tp1.Size = new System.Drawing.Size(636, 603);
            this.tp1.TabIndex = 1;
            this.tp1.Text = "Product 1";
            this.tp1.UseVisualStyleBackColor = true;
            // 
            // flpnproduct1
            // 
            this.flpnproduct1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpnproduct1.Location = new System.Drawing.Point(3, 3);
            this.flpnproduct1.Name = "flpnproduct1";
            this.flpnproduct1.Size = new System.Drawing.Size(630, 597);
            this.flpnproduct1.TabIndex = 0;
            // 
            // tp2
            // 
            this.tp2.Controls.Add(this.flpnproduct2);
            this.tp2.Location = new System.Drawing.Point(4, 25);
            this.tp2.Name = "tp2";
            this.tp2.Padding = new System.Windows.Forms.Padding(3);
            this.tp2.Size = new System.Drawing.Size(636, 603);
            this.tp2.TabIndex = 2;
            this.tp2.Text = "Product 2";
            this.tp2.UseVisualStyleBackColor = true;
            // 
            // flpnproduct2
            // 
            this.flpnproduct2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpnproduct2.Location = new System.Drawing.Point(3, 3);
            this.flpnproduct2.Name = "flpnproduct2";
            this.flpnproduct2.Size = new System.Drawing.Size(630, 597);
            this.flpnproduct2.TabIndex = 0;
            // 
            // grblistofinvoicedetails
            // 
            this.grblistofinvoicedetails.Controls.Add(this.txttotalprice);
            this.grblistofinvoicedetails.Controls.Add(this.btprintbill);
            this.grblistofinvoicedetails.Controls.Add(this.btpay);
            this.grblistofinvoicedetails.Controls.Add(this.btdelete);
            this.grblistofinvoicedetails.Controls.Add(this.lvproduct);
            this.grblistofinvoicedetails.Dock = System.Windows.Forms.DockStyle.Right;
            this.grblistofinvoicedetails.Location = new System.Drawing.Point(656, 0);
            this.grblistofinvoicedetails.Name = "grblistofinvoicedetails";
            this.grblistofinvoicedetails.Size = new System.Drawing.Size(626, 653);
            this.grblistofinvoicedetails.TabIndex = 2;
            this.grblistofinvoicedetails.TabStop = false;
            this.grblistofinvoicedetails.Text = "List Of Invoice Details";
            // 
            // txttotalprice
            // 
            this.txttotalprice.Dock = System.Windows.Forms.DockStyle.Right;
            this.txttotalprice.Location = new System.Drawing.Point(459, 568);
            this.txttotalprice.Multiline = true;
            this.txttotalprice.Name = "txttotalprice";
            this.txttotalprice.ReadOnly = true;
            this.txttotalprice.Size = new System.Drawing.Size(164, 82);
            this.txttotalprice.TabIndex = 4;
            this.txttotalprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btprintbill
            // 
            this.btprintbill.Dock = System.Windows.Forms.DockStyle.Left;
            this.btprintbill.Location = new System.Drawing.Point(303, 568);
            this.btprintbill.Name = "btprintbill";
            this.btprintbill.Size = new System.Drawing.Size(150, 82);
            this.btprintbill.TabIndex = 3;
            this.btprintbill.Text = "Print Bill";
            this.btprintbill.UseVisualStyleBackColor = true;
            this.btprintbill.Click += new System.EventHandler(this.btprintbill_Click);
            // 
            // btpay
            // 
            this.btpay.Dock = System.Windows.Forms.DockStyle.Left;
            this.btpay.Location = new System.Drawing.Point(153, 568);
            this.btpay.Name = "btpay";
            this.btpay.Size = new System.Drawing.Size(150, 82);
            this.btpay.TabIndex = 2;
            this.btpay.Text = "Pay";
            this.btpay.UseVisualStyleBackColor = true;
            this.btpay.Click += new System.EventHandler(this.btpay_Click);
            // 
            // btdelete
            // 
            this.btdelete.Dock = System.Windows.Forms.DockStyle.Left;
            this.btdelete.Location = new System.Drawing.Point(3, 568);
            this.btdelete.Name = "btdelete";
            this.btdelete.Size = new System.Drawing.Size(150, 82);
            this.btdelete.TabIndex = 1;
            this.btdelete.Text = "Delete";
            this.btdelete.UseVisualStyleBackColor = true;
            this.btdelete.Click += new System.EventHandler(this.btdelete_Click);
            // 
            // lvproduct
            // 
            this.lvproduct.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chid,
            this.chproductname,
            this.chunitprice,
            this.chquantity});
            this.lvproduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.lvproduct.HideSelection = false;
            this.lvproduct.Location = new System.Drawing.Point(3, 18);
            this.lvproduct.Name = "lvproduct";
            this.lvproduct.Size = new System.Drawing.Size(620, 550);
            this.lvproduct.TabIndex = 0;
            this.lvproduct.UseCompatibleStateImageBehavior = false;
            this.lvproduct.View = System.Windows.Forms.View.Details;
            this.lvproduct.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.lvproduct_ItemCheck);
            // 
            // chid
            // 
            this.chid.Text = "ID";
            this.chid.Width = 50;
            // 
            // chproductname
            // 
            this.chproductname.Text = "Product\'s name";
            this.chproductname.Width = 260;
            // 
            // chunitprice
            // 
            this.chunitprice.Text = "Unit price";
            this.chunitprice.Width = 200;
            // 
            // chquantity
            // 
            this.chquantity.Text = "Quantity";
            this.chquantity.Width = 100;
            // 
            // printPreviewDialogInvoice
            // 
            this.printPreviewDialogInvoice.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialogInvoice.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialogInvoice.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialogInvoice.Enabled = true;
            this.printPreviewDialogInvoice.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialogInvoice.Icon")));
            this.printPreviewDialogInvoice.Name = "printPreviewDialogInvoice";
            this.printPreviewDialogInvoice.Visible = false;
            // 
            // SalesPage3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 653);
            this.Controls.Add(this.grblistofinvoicedetails);
            this.Controls.Add(this.grblistofproduct);
            this.Name = "SalesPage3";
            this.Text = "SalesPage3";
            this.Load += new System.EventHandler(this.SalesPage3_Load);
            this.grblistofproduct.ResumeLayout(false);
            this.tcproduct.ResumeLayout(false);
            this.tpall.ResumeLayout(false);
            this.tp1.ResumeLayout(false);
            this.tp2.ResumeLayout(false);
            this.grblistofinvoicedetails.ResumeLayout(false);
            this.grblistofinvoicedetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grblistofproduct;
        private System.Windows.Forms.TabControl tcproduct;
        private System.Windows.Forms.TabPage tpall;
        private System.Windows.Forms.TabPage tp1;
        private System.Windows.Forms.GroupBox grblistofinvoicedetails;
        private System.Windows.Forms.TabPage tp2;
        private System.Windows.Forms.FlowLayoutPanel flpnall;
        private System.Windows.Forms.FlowLayoutPanel flpnproduct1;
        private System.Windows.Forms.FlowLayoutPanel flpnproduct2;
        private System.Windows.Forms.ListView lvproduct;
        private System.Windows.Forms.ColumnHeader chid;
        private System.Windows.Forms.ColumnHeader chproductname;
        private System.Windows.Forms.ColumnHeader chunitprice;
        private System.Windows.Forms.ColumnHeader chquantity;
        private System.Windows.Forms.TextBox txttotalprice;
        private System.Windows.Forms.Button btprintbill;
        private System.Windows.Forms.Button btpay;
        private System.Windows.Forms.Button btdelete;
        private System.Drawing.Printing.PrintDocument printDocumentInvoice;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialogInvoice;
    }
}