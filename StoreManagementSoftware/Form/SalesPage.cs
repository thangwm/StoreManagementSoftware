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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace StoreManagementSoftware
{
    public partial class SalesPage : Form
    {
        public SalesPage()
        {
            InitializeComponent();
        }

        private void SalesPage_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            Loaddata();
            LoaddataInvoice();
            LoaddataTable();
            LoaddataProduct();
        }

        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter adapter = new SqlDataAdapter();
        string str = "Data Source=DESKTOP-THANGWM\\SQLEXPRESS;Initial Catalog=StoreManagementSoftware;Integrated Security=True";

        void Loaddata()
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

        private void datainvoicedetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = datainvoicedetails.CurrentCell.RowIndex;
            txtid.Text = datainvoicedetails.Rows[i].Cells[0].Value.ToString();
            txttablename.Text = datainvoicedetails.Rows[i].Cells[1].Value.ToString();
            txtproductname.Text = datainvoicedetails.Rows[i].Cells[2].Value.ToString();
            txtquantity.Text = datainvoicedetails.Rows[i].Cells[3].Value.ToString();
            txtunitprice.Text = datainvoicedetails.Rows[i].Cells[4].Value.ToString();
        }

        private void lbadd_Click(object sender, EventArgs e)
        {
            try
            {
                command = connection.CreateCommand();
                command.CommandText = "Insert into InvoiceDetails Values('" + txtid.Text + "' , '" + txttablename.Text + "' , '" + txtproductname.Text + "' , '" + txtquantity.Text + "' , '" + txtunitprice.Text + "')";
                command.ExecuteNonQuery();
                Loaddata();
                MessageBox.Show("Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lbupdate_Click(object sender, EventArgs e)
        {
            try
            {
                command = connection.CreateCommand();
                command.CommandText = "Update InvoiceDetails Set tablename = '" + txttablename.Text + "' , productname = '" + txtproductname.Text + "' , quantity = '" + txtquantity.Text + "' , unitprice = '" + txtunitprice.Text + "' Where idinvoicedetails = '" + txtid.Text + "' and productname = '" + txtproductname.Text + "'";
                command.ExecuteNonQuery();
                Loaddata();
                MessageBox.Show("Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lbdelete_Click(object sender, EventArgs e)
        {
            try
            {
                command = connection.CreateCommand();
                command.CommandText = "Delete From InvoiceDetails Where idinvoicedetails = '" + txtid.Text + "' and productname = '" + txtproductname.Text + "'";
                command.ExecuteNonQuery();
                Loaddata();
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
                txtid.Text = "";
                txttablename.Text = "";
                txtproductname.Text = "";
                txtquantity.Text = "";
                txtunitprice.Text = "";
                command = connection.CreateCommand();
                command.CommandText = "Select * From InvoiceDetails Where idinvoicedetails is null";
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
                MessageBox.Show("Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btrefresh_Click(object sender, EventArgs e)
        {
            try
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
                int row = datainvoicedetails.Rows.Count;
                float totalPrice = 0;
                for (int i = 0; i < row - 1; i++)
                {
                    totalPrice += float.Parse(datainvoicedetails.Rows[i].Cells[4].Value.ToString())* float.Parse(datainvoicedetails.Rows[i].Cells[3].Value.ToString());
                }
                txttotalprice.Text = totalPrice.ToString();
                MessageBox.Show("Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }        

        void LoaddataInvoice()
        {
            command = connection.CreateCommand();
            command.CommandText = "Select * From Invoice";
            adapter.SelectCommand = command;
            DataTable table = new DataTable();
            table.Clear();
            adapter.Fill(table);
        }

        private void btpay_Click(object sender, EventArgs e)
        {
            try
            {
                command = connection.CreateCommand();
                command.CommandText = "Insert into Invoice Values('" + txtid.Text + "' , '" + txttotalprice.Text + "' , '" + txtdatefounded.Text + "')";
                command.ExecuteNonQuery();
                Loaddata();
                MessageBox.Show("Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lbprint_Click(object sender, EventArgs e)
        {

        }

        void LoaddataTable()
        {
            command = connection.CreateCommand();
            command.CommandText = "Select * From DinnerTable";
            adapter.SelectCommand = command;
            DataTable table = new DataTable();
            table.Clear();
            adapter.Fill(table);
            datatable.DataSource = table;
            datatable.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            datatable.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            datatable.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void datatable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = datatable.CurrentCell.RowIndex;
            txttablename.Text = datatable.Rows[i].Cells[1].Value.ToString();
        }

        private void btsearchtable_Click(object sender, EventArgs e)
        {
            try
            {
                command = connection.CreateCommand();
                command.CommandText = "Select idtable, tablename ,status From DinnerTable Where idtable = '" + txtfindtable.Text + "'";
                adapter.SelectCommand = command;
                DataTable table = new DataTable();
                table.Clear();
                adapter.Fill(table);
                datatable.DataSource = table;
                command.ExecuteNonQuery();
                MessageBox.Show("Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btresettable_Click(object sender, EventArgs e)
        {
            try
            {
                txttablename.Text = "";
                LoaddataTable();
                MessageBox.Show("Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btupdatetable_Click(object sender, EventArgs e)
        {
            TablePage f = new TablePage();
            f.ShowDialog();
            LoaddataTable();
        }

        void LoaddataProduct()
        {
            command = connection.CreateCommand();
            command.CommandText = "Select idproduct, productname ,producttype, unitprice From Product";
            adapter.SelectCommand = command;
            DataTable table = new DataTable();
            table.Clear();
            adapter.Fill(table);
            dataproduct.DataSource = table;
            dataproduct.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataproduct.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataproduct.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataproduct.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void dataproduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dataproduct.CurrentCell.RowIndex;
            txtproductname.Text = dataproduct.Rows[i].Cells[1].Value.ToString();
            txtunitprice.Text = dataproduct.Rows[i].Cells[3].Value.ToString();
        }

        private void btsearchproduct_Click(object sender, EventArgs e)
        {
            try
            {
                command = connection.CreateCommand();
                command.CommandText = "Select idproduct, productname ,producttype, unitprice From Product Where idproduct = '" + txtfindproduct.Text + "'";
                adapter.SelectCommand = command;
                DataTable table = new DataTable();
                table.Clear();
                adapter.Fill(table);
                dataproduct.DataSource = table;
                command.ExecuteNonQuery();
                MessageBox.Show("Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btresetproduct_Click(object sender, EventArgs e)
        {
            try
            {
                txtfindproduct.Text = "";
                LoaddataProduct();
                MessageBox.Show("Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
    }
}
