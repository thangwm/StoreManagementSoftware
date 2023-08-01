using StoreManagementSoftware.FormAdd;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreManagementSoftware
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            if (MainClass.USERNAME == "thangwm")
            {
                OpenchildForm(new HomePage());
            }
            else
            {
                OpenchildForm(new HomePage());
            }
            lbusernamemain.Text = MainClass.USERNAME;
        }

        #region currentFormChild

        private Form currentFormChild;

        private void OpenchildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            if (MainClass.USERNAME == "thangwm")
            {
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                pnview.Controls.Add(childForm);
                pnview  .Tag = childForm;
                childForm.BringToFront();
                childForm.Show();
            }
            else if (childForm is HomePage || childForm is SalesPage || childForm is SalesPage2 || childForm is SalesPage3 || childForm is ImportPage || childForm is InventoryPage || childForm is ExpiredProductPage || childForm is ProductTypePage || childForm is ProductPage || childForm is InvoicePage)
            {
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                pnview.Controls.Add(childForm);
                pnview.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();
            }
            else
            {
                MessageBox.Show("You do not have access!");
            }
        }

        private void bthomepage_Click(object sender, EventArgs e)
        {
            OpenchildForm(new HomePage());
        }

        private void btsalespage_Click(object sender, EventArgs e)
        {
            OpenchildForm(new SalesPage());
        }

        private void btsalespage2_Click(object sender, EventArgs e)
        {
            OpenchildForm(new SalesPage2());
        }

        private void btsalespage3_Click(object sender, EventArgs e)
        {
            OpenchildForm(new SalesPage3());
        }

        private void btimportpage_Click(object sender, EventArgs e)
        {
            OpenchildForm(new ImportPage());
        }

        private void btinventorypage_Click(object sender, EventArgs e)
        {
            OpenchildForm(new InventoryPage());
        }

        private void btexpiredproductpage_Click(object sender, EventArgs e)
        {
            OpenchildForm(new ExpiredProductPage());
        }

        private void bttablepage_Click(object sender, EventArgs e)
        {
            OpenchildForm(new TablePage());
        }

        private void btproducttypepage_Click(object sender, EventArgs e)
        {
            OpenchildForm(new ProductTypePage());
        }

        private void btproductpage_Click(object sender, EventArgs e)
        {
            OpenchildForm(new ProductPage());
        }

        private void btinvoicepage_Click(object sender, EventArgs e)
        {
            OpenchildForm(new InvoicePage());
        }

        private void btstatisticspage_Click(object sender, EventArgs e)
        {
            OpenchildForm(new StatisticsPage());
        }

        private void btcustomerinformationpage_Click(object sender, EventArgs e)
        {
            OpenchildForm(new CustomerInformationPage());
        }

        private void btemployeeinformationpage_Click(object sender, EventArgs e)
        {
            OpenchildForm(new EmployeeInformationPage());
        }

        private void btaccountpage_Click(object sender, EventArgs e)
        {
            OpenchildForm(new AccountPage());
        }

        #endregion

        private void ptbsizebars_Click(object sender, EventArgs e)
        {
            //if (pnsizebars.Width == 82)
            //{
            //    pnsizebars.Visible = false;
            //    pnsizebars.Width = 300;
            //    gunaTransition.ShowSync(pnsizebars);
            //}
            //else
            //{
            //    pnsizebars.Visible = true;
            //    pnsizebars.Width = 82;
            //    gunaTransition.ShowSync(pnsizebars);
            //}
        }

        private void btlogout_Click(object sender, EventArgs e)
        {
            this.Close();
            Login f = new Login();
            f.Show();
            this.Hide();
        }
        
    }
}
