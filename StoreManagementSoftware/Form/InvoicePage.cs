using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreManagementSoftware
{
    public partial class InvoicePage : Form
    {
        public InvoicePage()
        {
            InitializeComponent();
        }

        private void InvoicePage_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            Loaddata();
            LoaddataInvoiceDetails();
        }

        SqlConnection connection;
        SqlCommand command;
        string str = "Data Source=DESKTOP-THANGWM\\SQLEXPRESS;Initial Catalog=StoreManagementSoftware;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();

        void Loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "Select * From Invoice";
            adapter.SelectCommand = command;
            DataTable table = new DataTable();
            table.Clear();
            adapter.Fill(table);
            datainvoice.DataSource = table;
            datainvoice.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            datainvoice.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            datainvoice.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void datainvoice_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = datainvoice.CurrentCell.RowIndex;
            txtid.Text = datainvoice.Rows[i].Cells[0].Value.ToString();
            txttotalprice.Text = datainvoice.Rows[i].Cells[1].Value.ToString();
            txtdatefounded.Text = datainvoice.Rows[i].Cells[2].Value.ToString();
        }

        private void btsearch_Click(object sender, EventArgs e)
        {
            try
            {
                command = connection.CreateCommand();
                command.CommandText = "Select idinvoicedetails, totalprice ,datefounded From Invoice Where idinvoicedetails = '" + txtfind.Text + "'";
                adapter.SelectCommand = command;
                DataTable table = new DataTable();
                table.Clear();
                adapter.Fill(table);
                datainvoice.DataSource = table;
                command.ExecuteNonQuery();
                MessageBox.Show("Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btreset_Click(object sender, EventArgs e)
        {
            try
            {
                txtfind.Text = "";
                Loaddata();
                MessageBox.Show("Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void LoaddataInvoiceDetails()
        {
            command = connection.CreateCommand();
            command.CommandText = "Select * From InvoiceDetails Where idinvoicedetails = '" + txtid.Text + "'";
            adapter.SelectCommand = command;
            DataTable table = new DataTable();
            table.Clear();
            adapter.Fill(table);
            datainvoicedetails.DataSource = table;
            datainvoicedetails.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            datainvoicedetails.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            datainvoicedetails.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            datainvoicedetails.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            datainvoicedetails.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void btinvoicedetails_Click(object sender, EventArgs e)
        {
            try
            {
                LoaddataInvoiceDetails();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }           
        }

        private void btprint_Click(object sender, EventArgs e)
        {

        }
        
    }
}
