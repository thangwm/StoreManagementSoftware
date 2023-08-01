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
    public partial class ProductPage : Form
    {
        public ProductPage()
        {
            InitializeComponent();
        }

        private void ProductPage_Load(object sender, EventArgs e)
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
            command.CommandText = "Select idproduct, productname ,producttype, unitprice From Product";
            adapter.SelectCommand = command;
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
            txtid.Text = dataproduct.Rows[i].Cells[0].Value.ToString();
            txtproductname.Text = dataproduct.Rows[i].Cells[1].Value.ToString();
            txtproducttype.Text = dataproduct.Rows[i].Cells[2].Value.ToString();
            txtunitprice.Text = dataproduct.Rows[i].Cells[3].Value.ToString();
            //byte[] b = (byte[])dataproduct.Rows[i].Cells[4].Value;
            //ptbproduct.Image = ByteArrayToImage(b);
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
                    ptbproduct.Image = Image.FromFile(ofd.FileName);
                }
                MessageBox.Show("Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ptbproduct_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    ptbproduct.Image = Image.FromFile(ofd.FileName);
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
                byte[] b = ImageToByteArray(ptbproduct.Image);
                //byte[] b = PathToByteArray(this.Text);
                command = connection.CreateCommand();
                command.CommandText = "Insert into Product Values('" + txtproductname.Text + "' , '" + txtproducttype.Text + "' , '" + txtunitprice.Text + "' , '" + b + "')";
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
                byte[] b = ImageToByteArray(ptbproduct.Image);
                //byte[] b = PathToByteArray(this.Text);
                command = connection.CreateCommand();
                command.CommandText = "Update Product Set productname = '" + txtproductname.Text + "' , producttype = '" + txtproducttype.Text + "' , unitprice = '" + txtunitprice.Text + "' , imageproduct = '" + b + "' Where idproduct = '" + txtid.Text + "'";
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
                command.CommandText = "Delete From Product Where idproduct = '" + txtid.Text + "'";
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
                txtproductname.Text = "";
                txtproducttype.Text = "";                
                txtunitprice.Text = "";            
                ptbproduct.Image = null;
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
                command.CommandText = "Select idproduct, productname ,producttype, unitprice From Product Where idproduct = '" + txtfind.Text + "'";
                adapter.SelectCommand = command;
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
