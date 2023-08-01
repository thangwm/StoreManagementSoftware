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
    public partial class TablePage : Form
    {
        public TablePage()
        {
            InitializeComponent();
        }

        private void TablePage_Load(object sender, EventArgs e)
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
            command.CommandText = "Select * From DinnerTable";
            adapter.SelectCommand = command;
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
            txtid.Text = datatable.Rows[i].Cells[0].Value.ToString();           
            txttablename.Text = datatable.Rows[i].Cells[1].Value.ToString();
            txtstatus.Text = datatable.Rows[i].Cells[2].Value.ToString();
        }

        private void btadd_Click(object sender, EventArgs e)
        {
            try
            {
                command = connection.CreateCommand();
                command.CommandText = "Insert into DinnerTable Values('" + txttablename.Text + "' , '" + txtstatus.Text + "')";
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
                command.CommandText = "Update DinnerTable Set tablename = '" + txttablename.Text + "' , status = '" + txtstatus.Text + " ' Where idtable = '" + txtid.Text + "'";
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
                command.CommandText = "Delete From DinnerTable Where idtable = '" + txtid.Text + "'";
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
                txttablename.Text = "";
                txtstatus.Text = "";
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
                command.CommandText = "Select idtable, tablename ,status From DinnerTable Where idtable = '" + txtfind.Text + "'";
                adapter.SelectCommand = command;
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
