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
    public partial class ProductTypePage : Form
    {
        public ProductTypePage()
        {
            InitializeComponent();
        }

        private void ProductTypePage_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            Loaddata();
        }

        SqlConnection connection;
        SqlCommand command;
        string str = "Data Source=DESKTOP-THANGWM\\SQLEXPRESS;Initial Catalog=StoreManagementSoftware;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void Loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "Select * From ProductType";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dataproducttype.DataSource = table;
            dataproducttype.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataproducttype.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void dataproducttype_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dataproducttype.CurrentCell.RowIndex;
            txtid.Text = dataproducttype.Rows[i].Cells[0].Value.ToString();
            txtproducttype.Text = dataproducttype.Rows[i].Cells[1].Value.ToString();
        }

        private void btadd_Click(object sender, EventArgs e)
        {
            try
            {
                command = connection.CreateCommand();
                command.CommandText = "Insert into ProductType Values('" + txtid.Text + "' , '" + txtproducttype.Text + "')";
                command.ExecuteNonQuery();
                Loaddata();
                MessageBox.Show("Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btupdate_Click(object sender, EventArgs e)
        {
            try
            {
                command = connection.CreateCommand();
                command.CommandText = "Update ProductType Set producttype = '" + txtproducttype.Text + "' Where idproducttype = '" + txtid.Text + "'";
                command.ExecuteNonQuery();
                Loaddata();
                MessageBox.Show("Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btdelete_Click(object sender, EventArgs e)
        {
            try
            {
                command = connection.CreateCommand();
                command.CommandText = "Delete From ProductType Where idproducttype = '" + txtid.Text + "'";
                command.ExecuteNonQuery();
                Loaddata();
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
                txtid.Text = "";
                txtproducttype.Text = "";
                MessageBox.Show("Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btsearch_Click(object sender, EventArgs e)
        {
            try
            {
                command = connection.CreateCommand();
                command.CommandText = "Select * From ProductType Where idproducttype = '" + txtfind.Text + "'";
                adapter.SelectCommand = command;
                table.Clear();
                adapter.Fill(table);
                dataproducttype.DataSource = table;
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
                Loaddata();
                MessageBox.Show("Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
