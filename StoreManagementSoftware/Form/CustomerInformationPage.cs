using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreManagementSoftware
{
    public partial class CustomerInformationPage : Form
    {
        public CustomerInformationPage()
        {
            InitializeComponent();
        }

        private void CustomerInformationPage_Load(object sender, EventArgs e)
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
            command.CommandText = "Select idcustomer, fullname, gender, dateofbirth, address, email, phone, member From CustomerInformation";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            datacustomer.DataSource = table;
            datacustomer.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            datacustomer.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            datacustomer.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            datacustomer.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            datacustomer.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            datacustomer.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            datacustomer.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            datacustomer.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //datacustomer.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void datacustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = datacustomer.CurrentCell.RowIndex;
            txtid.Text = datacustomer.Rows[i].Cells[0].Value.ToString();
            txtfullname.Text = datacustomer.Rows[i].Cells[1].Value.ToString();
            txtgender.Text = datacustomer.Rows[i].Cells[2].Value.ToString();
            txtdateofbirth.Text = datacustomer.Rows[i].Cells[3].Value.ToString();
            txtaddress.Text = datacustomer.Rows[i].Cells[4].Value.ToString();
            txtemail.Text = datacustomer.Rows[i].Cells[5].Value.ToString();
            txtphone.Text = datacustomer.Rows[i].Cells[6].Value.ToString();
            txtmember.Text = datacustomer.Rows[i].Cells[7].Value.ToString();
            //byte[] b = (byte[])datacustomer.Rows[i].Cells[8].Value;
            //ptbcustomer.Image = ByteArrayToImage(b);
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
                    ptbcustomer.Image = Image.FromFile(ofd.FileName);
                }
                MessageBox.Show("Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ptbcustomer_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    ptbcustomer.Image = Image.FromFile(ofd.FileName);
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
                byte[] b = ImageToByteArray(ptbcustomer.Image);
                //byte[] b = PathToByteArray(this.Text);
                command = connection.CreateCommand();
                command.CommandText = "Insert into CustomerInformation Values('" + txtfullname.Text + "' , '" + txtgender.Text + "' , '" + txtdateofbirth.Text + "' , '" + txtaddress.Text + "', '" + txtemail.Text + "' , '" + txtphone.Text + "' , '" + txtmember.Text + "' , '" + b + "')";
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
                byte[] b = ImageToByteArray(ptbcustomer.Image);
                //byte[] b = PathToByteArray(this.Text);
                command = connection.CreateCommand();
                command.CommandText = "Update CustomerInformation Set fullname = '" + txtfullname.Text + "' , gender = '" + txtgender.Text + "' , dateofbirth = '" + txtdateofbirth.Text + "' , address = '" + txtaddress.Text + "', email = '" + txtemail.Text + "' , phone = '" + txtphone.Text + "' , member = '" + txtmember.Text + "' , imagecustomer = '" + b + "' Where idcustomer = '" + txtid.Text + "'";
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
                command.CommandText = "Delete From CustomerInformation Where idcustomer = '" + txtid.Text + "'";
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
                txtmember.Text = "";
                ptbcustomer.Image = null;
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
                command.CommandText = "Select idcustomer, fullname, gender, dateofbirth, address, email, phone, member From CustomerInformation Where idcustomer = '" + txtfind.Text + "'";
                adapter.SelectCommand = command;
                table.Clear();
                adapter.Fill(table);
                datacustomer.DataSource = table;
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
