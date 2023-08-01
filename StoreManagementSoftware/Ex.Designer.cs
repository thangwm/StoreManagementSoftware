namespace StoreManagementSoftware
{
    partial class Ex
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
            this.lbtablename = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txttable = new System.Windows.Forms.TextBox();
            this.lbid = new System.Windows.Forms.Label();
            this.datainvoicedetails = new System.Windows.Forms.DataGridView();
            this.pntable = new System.Windows.Forms.FlowLayoutPanel();
            this.txtquantity = new System.Windows.Forms.NumericUpDown();
            this.btaddtable = new System.Windows.Forms.Button();
            this.lbaddtable = new System.Windows.Forms.Label();
            this.grblistoftable = new System.Windows.Forms.GroupBox();
            this.grblistofinvoicedetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datainvoicedetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtquantity)).BeginInit();
            this.grblistoftable.SuspendLayout();
            this.SuspendLayout();
            // 
            // grblistofinvoicedetails
            // 
            this.grblistofinvoicedetails.Controls.Add(this.lbtablename);
            this.grblistofinvoicedetails.Controls.Add(this.txtid);
            this.grblistofinvoicedetails.Controls.Add(this.txttable);
            this.grblistofinvoicedetails.Controls.Add(this.lbid);
            this.grblistofinvoicedetails.Controls.Add(this.datainvoicedetails);
            this.grblistofinvoicedetails.Dock = System.Windows.Forms.DockStyle.Right;
            this.grblistofinvoicedetails.Location = new System.Drawing.Point(560, 0);
            this.grblistofinvoicedetails.Name = "grblistofinvoicedetails";
            this.grblistofinvoicedetails.Size = new System.Drawing.Size(729, 717);
            this.grblistofinvoicedetails.TabIndex = 11;
            this.grblistofinvoicedetails.TabStop = false;
            this.grblistofinvoicedetails.Text = "List Of Invoice Details";
            // 
            // lbtablename
            // 
            this.lbtablename.AutoSize = true;
            this.lbtablename.Location = new System.Drawing.Point(12, 100);
            this.lbtablename.Name = "lbtablename";
            this.lbtablename.Size = new System.Drawing.Size(83, 16);
            this.lbtablename.TabIndex = 12;
            this.lbtablename.Text = "Table name:";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(100, 44);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 22);
            this.txtid.TabIndex = 11;
            // 
            // txttable
            // 
            this.txttable.Location = new System.Drawing.Point(101, 94);
            this.txttable.Name = "txttable";
            this.txttable.Size = new System.Drawing.Size(100, 22);
            this.txttable.TabIndex = 10;
            // 
            // lbid
            // 
            this.lbid.AutoSize = true;
            this.lbid.Location = new System.Drawing.Point(12, 50);
            this.lbid.Name = "lbid";
            this.lbid.Size = new System.Drawing.Size(23, 16);
            this.lbid.TabIndex = 1;
            this.lbid.Text = "ID:";
            // 
            // datainvoicedetails
            // 
            this.datainvoicedetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datainvoicedetails.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.datainvoicedetails.Location = new System.Drawing.Point(3, 414);
            this.datainvoicedetails.Name = "datainvoicedetails";
            this.datainvoicedetails.RowHeadersWidth = 51;
            this.datainvoicedetails.RowTemplate.Height = 24;
            this.datainvoicedetails.Size = new System.Drawing.Size(723, 300);
            this.datainvoicedetails.TabIndex = 0;
            // 
            // pntable
            // 
            this.pntable.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pntable.Location = new System.Drawing.Point(3, 164);
            this.pntable.Name = "pntable";
            this.pntable.Size = new System.Drawing.Size(544, 550);
            this.pntable.TabIndex = 19;
            // 
            // txtquantity
            // 
            this.txtquantity.Location = new System.Drawing.Point(100, 44);
            this.txtquantity.Name = "txtquantity";
            this.txtquantity.Size = new System.Drawing.Size(50, 22);
            this.txtquantity.TabIndex = 18;
            this.txtquantity.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // btaddtable
            // 
            this.btaddtable.Location = new System.Drawing.Point(200, 43);
            this.btaddtable.Name = "btaddtable";
            this.btaddtable.Size = new System.Drawing.Size(107, 23);
            this.btaddtable.TabIndex = 15;
            this.btaddtable.Text = "Add Table";
            this.btaddtable.UseVisualStyleBackColor = true;
            this.btaddtable.Click += new System.EventHandler(this.btaddtable_Click);
            // 
            // lbaddtable
            // 
            this.lbaddtable.AutoSize = true;
            this.lbaddtable.Location = new System.Drawing.Point(12, 50);
            this.lbaddtable.Name = "lbaddtable";
            this.lbaddtable.Size = new System.Drawing.Size(74, 16);
            this.lbaddtable.TabIndex = 9;
            this.lbaddtable.Text = "Add Table:";
            // 
            // grblistoftable
            // 
            this.grblistoftable.Controls.Add(this.pntable);
            this.grblistoftable.Controls.Add(this.txtquantity);
            this.grblistoftable.Controls.Add(this.btaddtable);
            this.grblistoftable.Controls.Add(this.lbaddtable);
            this.grblistoftable.Dock = System.Windows.Forms.DockStyle.Left;
            this.grblistoftable.Location = new System.Drawing.Point(0, 0);
            this.grblistoftable.Name = "grblistoftable";
            this.grblistoftable.Size = new System.Drawing.Size(550, 717);
            this.grblistoftable.TabIndex = 10;
            this.grblistoftable.TabStop = false;
            this.grblistoftable.Text = "List Of Table";
            // 
            // Ex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1289, 717);
            this.Controls.Add(this.grblistofinvoicedetails);
            this.Controls.Add(this.grblistoftable);
            this.Name = "Ex";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ex";
            this.grblistofinvoicedetails.ResumeLayout(false);
            this.grblistofinvoicedetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datainvoicedetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtquantity)).EndInit();
            this.grblistoftable.ResumeLayout(false);
            this.grblistoftable.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grblistofinvoicedetails;
        private System.Windows.Forms.Label lbtablename;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txttable;
        private System.Windows.Forms.Label lbid;
        private System.Windows.Forms.DataGridView datainvoicedetails;
        private System.Windows.Forms.FlowLayoutPanel pntable;
        private System.Windows.Forms.NumericUpDown txtquantity;
        private System.Windows.Forms.Button btaddtable;
        private System.Windows.Forms.Label lbaddtable;
        private System.Windows.Forms.GroupBox grblistoftable;
    }
}