using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StoreManagementSoftware
{
    public partial class SalesPage3 : Form
    {
        public SalesPage3()
        {
            InitializeComponent();
        }

        private readonly string connectionString = "Data Source=DESKTOP-THANGWM\\SQLEXPRESS;Initial Catalog=StoreManagementSoftware;Integrated Security=True";
        private readonly List<ProductTemp> selectedProducts = new List<ProductTemp>();
        private readonly Label lblTotalPrice = new Label();

        class ProductTemp
        {
            public int idproduct { get; set; }
            public string productname { get; set; }
            public string producttype { get; set; }
            public int unitprice { get; set; }
            public int quantity { get; set; }
        }

        private void SalesPage3_Load(object sender, EventArgs e)
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string str = "Select imageproduct From Product";
                    using (var command = new SqlCommand(str, connection))
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            byte[] imageData = (byte[])reader["imageproduct"];
                            PictureBox pictureBox = new PictureBox();
                            pictureBox.Image = Image.FromStream(new MemoryStream(imageData));
                            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                            pictureBox.Width = 90;
                            pictureBox.Height = 90;
                            pictureBox.Margin = new Padding(3);
                            pictureBox.Click += pictureBox_Click;
                            flpnall.Controls.Add(pictureBox);
                            lblTotalPrice.Text = "Total price: 0";
                            lblTotalPrice.AutoSize = true;
                            lblTotalPrice.Location = new Point(10, 120);
                            Controls.Add(lblTotalPrice);
                        }
                    }
                }
                LoadProduct1();
                LoadProduct2();
                MessageBox.Show("Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }                  
        }

        private void LoadProduct1()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            int idproducttype = 1;
            string str = "Select productname, unitprice, imageproduct From Product Where  idproductype = " + idproducttype;
            SqlCommand command = new SqlCommand(str, connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string productname = reader.GetString(0);
                int unitprice = reader.GetInt32(1);
                byte[] imageproduct = (byte[])reader.GetValue(2);
                MemoryStream ms = new MemoryStream(imageproduct);
                Image imageProduct = Image.FromStream(ms);
                byte[] imageData = (byte[])reader["imageproduct"];
                PictureBox pictureBox = new PictureBox();
                pictureBox.Image = Image.FromStream(new MemoryStream(imageData));
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Width = 90;
                pictureBox.Height = 90;
                pictureBox.Margin = new Padding(3);
                pictureBox.Click += pictureBox_Click;
                flpnproduct1.Controls.Add(pictureBox);
            }
            reader.Close();
            connection.Close();
        }

        private void LoadProduct2()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            int idproducttype = 2;
            string str = "Select productname, unitprice, imageproduct From Product Where  idproductype = " + idproducttype;
            SqlCommand command = new SqlCommand(str, connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string productname = reader.GetString(0);
                int unitprice = reader.GetInt32(1);
                byte[] imageproduct = (byte[])reader.GetValue(2);
                MemoryStream ms = new MemoryStream(imageproduct);
                Image imageProduct = Image.FromStream(ms);
                byte[] imageData = (byte[])reader["imageproduct"];
                PictureBox pictureBox = new PictureBox();
                pictureBox.Image = Image.FromStream(new MemoryStream(imageData));
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Width = 90;
                pictureBox.Height = 90;
                pictureBox.Margin = new Padding(3);
                pictureBox.Click += pictureBox_Click;
                flpnproduct2.Controls.Add(pictureBox);
            }
            reader.Close();
            connection.Close();
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                PictureBox pictureBox = (PictureBox)sender;
                byte[] imageData = (byte[])new ImageConverter().ConvertTo(pictureBox.Image, typeof(byte[]));
                string str = "Select idproduct, productname, producttype, unitprice From Product Where imageproduct = @imageproduct";
                using (var command = new SqlCommand(str, connection))
                {
                    command.Parameters.AddWithValue("@imageproduct", imageData);
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int idProduct = reader.GetInt32(0);
                            string productName = reader.GetString(1);
                            string productType = reader.GetString(2);
                            int unitPrice = reader.GetInt32(3);
                            var selectedProduct = selectedProducts.FirstOrDefault(p => p.productname == productName);
                            if (selectedProduct != null)
                            {
                                selectedProduct.quantity++;
                                UpdateSelectedProduct(selectedProduct);
                            }
                            else
                            {
                                var product = new ProductTemp
                                {
                                    idproduct = idProduct,
                                    productname = productName,
                                    producttype = productType,
                                    unitprice = unitPrice,
                                    quantity = 1
                                };
                                selectedProducts.Add(product);
                                AddSelectedProductToListView(product);
                            }
                            UpdateTotalPrice();
                            btdelete.Click += btdelete_Click;
                        }
                    }
                }
            }
        }

        private void AddSelectedProductToListView(ProductTemp product)
        {
            ListViewItem item = new ListViewItem(product.idproduct.ToString());
            item.SubItems.Add(product.productname.ToString());
            item.SubItems.Add(product.producttype.ToString());
            item.SubItems.Add(product.unitprice.ToString());
            item.SubItems.Add(product.quantity.ToString());
            lvproduct.Items.Add(item);
        }

        private void UpdateSelectedProduct(ProductTemp product)
        {
            foreach (ListViewItem item in lvproduct.Items)
            {
                if (item.Text == product.idproduct.ToString())
                {
                    item.SubItems[4].Text = product.quantity.ToString();
                    break;
                }
            }
        }

        private void lvproduct_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            UpdateTotalPrice();
        }

        private int CalculateTotalPrice()
        {
            int totalPrice = 0;
            foreach (var product in selectedProducts)
            {
                totalPrice += product.unitprice * product.quantity;
            }
            return totalPrice;
        }

        private void UpdateTotalPrice()
        {
            int totalPrice = CalculateTotalPrice();
            lblTotalPrice.Text = "Total price: " + totalPrice.ToString("N0") + " VNĐ";
            txttotalprice.Text = totalPrice.ToString("N0") + " VNĐ";
        }

        private void btdelete_Click(object sender, EventArgs e)
        {
            if (lvproduct.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lvproduct.SelectedItems[0];
                string idProduct = selectedItem.SubItems[0].Text;
                var selectedProduct = selectedProducts.FirstOrDefault(p => p.idproduct.ToString() == idProduct);
                if (selectedProduct != null)
                {
                    selectedProducts.Remove(selectedProduct);
                    lvproduct.Items.Remove(selectedItem);
                    UpdateTotalPrice();
                }
            }
        }

        private void btpay_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to pay " + txttotalprice.Text + " money?", "Confirm", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string connectionString = "Data Source=DESKTOP-THANGWM\\SQLEXPRESS;Initial Catalog=StoreManagementSoftware;Integrated Security=True"; 
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("Insert Into InvoiceDetails2 (idinvoicedetails, idinvoice, quantity, totalprice, datefounded) Values (@idinvoicedetails, @idinvoice, @quantity, @totalprice, @datefounded)", connection);
                    foreach (ListViewItem item in lvproduct.Items)
                    {
                        int idprodcut = Convert.ToInt32(item.SubItems[0].Text);
                        string productname = item.SubItems[1].Text;
                        string productype = item.SubItems[2].Text;
                        int unitprice = Convert.ToInt32(item.SubItems[3].Text);
                        int quantity = Convert.ToInt32(item.SubItems[4].Text);
                        int totalprice = unitprice * quantity;
                        command.Parameters.Clear();
                        command.Parameters.AddWithValue("@idinvoicedetails", idprodcut);
                        command.Parameters.AddWithValue("@idinvoice", DBNull.Value);
                        command.Parameters.AddWithValue("@quantity", quantity);
                        command.Parameters.AddWithValue("@totalprice", totalprice);
                        command.Parameters.AddWithValue("@datefounded", DateTime.Now);
                        int result = command.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Success!");
                            selectedProducts.Clear();
                            lvproduct.Items.Clear();
                            lblTotalPrice.Text = "Total price: 0";
                            txttotalprice.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Failure!");
                        }
                    }
                }
            }
        }

        private PrintDocument printDocument = new PrintDocument();

        void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        { 
            // Set the font and the brush to be used for drawing the text
            {
                Font titleFont = new Font("Arial", 16, FontStyle.Bold);
                Font headerFont = new Font("Arial", 12, FontStyle.Bold);
                Font contentFont = new Font("Arial", 12, FontStyle.Regular);
                SolidBrush brush = new SolidBrush(Color.Black);

                // Define the margins and offsets
                float startX = e.MarginBounds.Left;
                float startY = e.MarginBounds.Top;
                float offset = 20;
                float rightMargin = e.MarginBounds.Right;
                float leftMargin = e.MarginBounds.Left;

                // Create a rectangle to define the bounds of the text
                RectangleF rect = new RectangleF(leftMargin, startY, e.MarginBounds.Width, e.MarginBounds.Height);

                // Draw the title of the bill
                string title = "SHOP BILL";
                SizeF titleSize = e.Graphics.MeasureString(title, titleFont);
                float titleX = (e.PageBounds.Width - titleSize.Width) / 2;
                e.Graphics.DrawString(title, titleFont, brush, titleX, 50);

                // Draw the header of the bill
                float headerY = startY + titleSize.Height + offset;
                e.Graphics.DrawString("Product name", headerFont, brush, leftMargin, headerY);
                e.Graphics.DrawString("Quantity", headerFont, brush, rightMargin - 150, headerY);
                e.Graphics.DrawString("Unitprice", headerFont, brush, rightMargin - 10, headerY);

                // Draw the details of the selected products
                float contentY = headerY + offset;
                foreach (var product in selectedProducts)
                {
                    e.Graphics.DrawString(product.productname, contentFont, brush, leftMargin, contentY);
                    e.Graphics.DrawString(product.quantity.ToString(), contentFont, brush, rightMargin - 120, contentY);
                    e.Graphics.DrawString(product.unitprice.ToString("N0") + " VNĐ", contentFont, brush, rightMargin - 10, contentY);
                    contentY += offset;
                }

                // Draw the total price
                float totalPriceY = contentY + offset;
                e.Graphics.DrawString("Totalprice:", headerFont, brush, rightMargin - 150, totalPriceY);
                e.Graphics.DrawString(CalculateTotalPrice().ToString("N0") + " VNĐ", contentFont, brush, rightMargin - 10, totalPriceY);

                // Draw the time and date
                float timeY = totalPriceY + offset;
                string timeString = "Date Founded: " + DateTime.Now.ToString();
                e.Graphics.DrawString(timeString, contentFont, brush, rightMargin - 200, timeY - 240);

                // Draw a line to separate the content from the footer
                float lineY = e.MarginBounds.Bottom - 550;
                e.Graphics.DrawLine(new Pen(Color.Black), leftMargin, lineY, rightMargin, lineY);

                // Draw the footer of the bill
                float footerY = lineY + offset;
                e.Graphics.DrawString("Thank you very much!", headerFont, brush, leftMargin, footerY);
            }
        }

        private void btprintbill_Click(object sender, EventArgs e)
        {
            printDocumentInvoice.PrintPage += new PrintPageEventHandler(printDocument_PrintPage);

            // Set the printer settings to the default printer
            printDocumentInvoice.PrinterSettings = new PrinterSettings();

            // Show the print preview dialog
            printPreviewDialogInvoice.Document = printDocumentInvoice;
            printPreviewDialogInvoice.ShowDialog();
        }
    }
}
