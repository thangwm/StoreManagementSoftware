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
using System.IO;

namespace StoreManagementSoftware
{
    public partial class EmployeeInformationPage : Form
    {
        public EmployeeInformationPage()
        {
            InitializeComponent();
        }

        private void EmployeeInformationPage_Load(object sender, EventArgs e)
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
            command.CommandText = "Select idemployee, fullname, gender, dateofbirth, address, email, phone, position, salary  From EmployeeInformation";           
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dataemployee.DataSource = table;
            dataemployee.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataemployee.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataemployee.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataemployee.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataemployee.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataemployee.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataemployee.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataemployee.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataemployee.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //dataemployee.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void dataemployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {           
            int i = dataemployee.CurrentCell.RowIndex;
            txtid.Text = dataemployee.Rows[i].Cells[0].Value.ToString();
            txtfullname.Text = dataemployee.Rows[i].Cells[1].Value.ToString();
            txtgender.Text = dataemployee.Rows[i].Cells[2].Value.ToString();
            txtdateofbirth.Text = dataemployee.Rows[i].Cells[3].Value.ToString();
            txtaddress.Text = dataemployee.Rows[i].Cells[4].Value.ToString();
            txtemail.Text = dataemployee.Rows[i].Cells[5].Value.ToString();
            txtphone.Text = dataemployee.Rows[i].Cells[6].Value.ToString();
            txtposition.Text = dataemployee.Rows[i].Cells[7].Value.ToString();
            txtsalary.Text = dataemployee.Rows[i].Cells[8].Value.ToString();
            //byte[] b = (byte[])dataemployee.Rows[i].Cells[9].Value;
            //ptbemployee.Image = ByteArrayToImage(b);
        }

        byte[] ImageToByteArray(Image img)
        {
            MemoryStream memory = new MemoryStream();
            img.Save(memory, System.Drawing.Imaging.ImageFormat.Jpeg);
            return memory.ToArray();
        }

        //byte[] PathToByteArray(string path)
        //{
        //MemoryStream memory = new MemoryStream();
        //Image img = Image.FromFile(path);
        //img.Save(memory, System.Drawing.Imaging.ImageFormat.Png);
        //return memory.ToArray();

        //    return File.ReadAllBytes(path);
        //}

        Image ByteArrayToImage(byte[] b)
        {
            MemoryStream memory = new MemoryStream();
            return Image.FromStream(memory);
        }

        private void btaddptb_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|All Files (*.*)|*.*";
                ofd.InitialDirectory = "C:\\";
                ofd.Title = "Choose a photo";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    ptbemployee.Image = Image.FromFile(ofd.FileName);
                }
                MessageBox.Show("Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }           
        }

        private void ptbemployee_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    ptbemployee.Image = Image.FromFile(ofd.FileName);
                    this.Text = ofd.FileName;
                }
                MessageBox.Show("Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btadd_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] b = ImageToByteArray(ptbemployee.Image);
                //byte[] b = PathToByteArray(this.Text);
                command = connection.CreateCommand();
                command.CommandText = "Insert into EmployeeInformation Values('" + txtfullname.Text + "' , '" + txtgender.Text + "' , '" + txtdateofbirth.Text + "' , '" + txtaddress.Text + "', '" + txtemail.Text + "' , '" + txtphone.Text + "' , '" + txtposition.Text + "' , '" + txtsalary.Text + "' , '" + b + "')";
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
                byte[] b = ImageToByteArray(ptbemployee.Image);
                //byte[] b = PathToByteArray(this.Text);
                command = connection.CreateCommand();
                command.CommandText = "Update EmployeeInformation Set fullname = '" + txtfullname.Text + "' , gender = '" + txtgender.Text + "' , dateofbirth = '" + txtdateofbirth.Text + "' , address = '" + txtaddress.Text + "', email = '" + txtemail.Text + "' , phone = '" + txtphone.Text + "' , position = '" + txtposition.Text + "' , salary = '" + txtsalary.Text + "' , imageemployee = '" + b + "' Where idemployee = '" + txtid.Text + "'";
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
                command.CommandText = "Delete From EmployeeInformation Where idemployee = '" + txtid.Text + "'";
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
                txtfullname.Text = "";
                txtgender.Text = "";
                txtdateofbirth.Text = "12/30/2000";
                txtaddress.Text = "";
                txtemail.Text = "";
                txtphone.Text = "";
                txtposition.Text = "";
                txtsalary.Text = "";
                ptbemployee.Image = null;
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
                command.CommandText = "Select idemployee, fullname, gender, dateofbirth, address, email, phone, position, salarys From EmployeeInformation Where idemployee = '" + txtfind.Text + "'";
                adapter.SelectCommand = command;
                table.Clear();
                adapter.Fill(table);
                dataemployee.DataSource = table;
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
