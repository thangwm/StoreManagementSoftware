using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreManagementSoftware
{
    public partial class Ex : Form
    {
        public Ex()
        {
            InitializeComponent();
        }

        int count = 1;

        private void btaddtable_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= Convert.ToInt32(txtquantity.Value); i++)
            {
                Button btn = new Button();
                btn.Text = "ban so" + count.ToString();
                btn.Name = "banso" + count.ToString();
                btn.Size = new Size(90, 90);
                count++;
                pntable.Controls.Add(btn);
            }
        }
    }
}
