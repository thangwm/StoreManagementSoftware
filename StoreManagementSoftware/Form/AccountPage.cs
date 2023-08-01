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
    public partial class AccountPage : Form
    {
        public AccountPage()
        {
            InitializeComponent();
        }

        private void AccountPage_Load(object sender, EventArgs e)
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
            command.CommandText = "Select * From Account";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dataaccount.DataSource = table;
            dataaccount.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataaccount.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataaccount.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void dataaccount_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dataaccount.CurrentCell.RowIndex;
            txtid.Text = dataaccount.Rows[i].Cells[0].Value.ToString();
            txtusername.Text = dataaccount.Rows[i].Cells[1].Value.ToString();
            txtpassword.Text = dataaccount.Rows[i].Cells[2].Value.ToString();
        }

        private void btadd_Click(object sender, EventArgs e)
        {
            try
            {              
                command = connection.CreateCommand();
                command.CommandText = "Insert into Account Values('" + txtid.Text + "' , '" + txtusername.Text + "' , '" + txtpassword.Text + "')";
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
                command.CommandText = "Update Account Set username = '" + txtusername.Text + "' , password = '" + txtpassword.Text + " ' Where idemployee = '" + txtid.Text + "'";
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
                command.CommandText = "Delete From Account Where idemployee = '" + txtid.Text + "'";
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
                txtusername.Text = "";
                txtpassword.Text = "";                
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
                command.CommandText = "Select idemployee, username ,password From Account Where idemployee = '" + txtfind.Text + "'";
                adapter.SelectCommand = command;
                table.Clear();
                adapter.Fill(table);
                dataaccount.DataSource = table;
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
        
    }
}
