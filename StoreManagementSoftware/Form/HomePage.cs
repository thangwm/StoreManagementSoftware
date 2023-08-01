using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreManagementSoftware
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            ptbview.ImageLocation = string.Format(@"D:\C#\StoreManagementSoftware\StoreManagementSoftware\Images\View\" + ImageNumber + ".jpg");
        }

        private int ImageNumber = 1;

        private void LoadNextImages()
        {
            time.Start();
            ImageNumber++;
            if (ImageNumber > 4)
            {
                ImageNumber = 1;
            }
            ptbview.ImageLocation = string.Format(@"D:\C#\StoreManagementSoftware\StoreManagementSoftware\Images\View\" + ImageNumber + ".jpg");
        }

        private void LoadImages()
        {
            time.Start();
            ImageNumber--;
            if (ImageNumber < 1)
            {
                ImageNumber = 4;
            }
            ptbview.ImageLocation = string.Format(@"D:\C#\StoreManagementSoftware\StoreManagementSoftware\Images\View\" + ImageNumber + ".jpg");
        }

        private void time_Tick(object sender, EventArgs e)
        {
            LoadNextImages();
        }

        private void btleft_Click(object sender, EventArgs e)
        {
            time.Stop();
            LoadImages();
        }

        private void btright_Click(object sender, EventArgs e)
        {
            time.Stop();
            LoadNextImages();
        }

    }
}
