using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UC
{
    public partial class Details : UserControl
    {

        public string Name
        {
            get => namelbl.Text;
            set
            {
                namelbl.Text = value;
            }
        }

        public double Price
        {
            get => double.Parse(pricelbl.Text);
            set
            {
                pricelbl.Text = value.ToString();
            }
        }

        public Image ProductImage
        {
            get
            {
                return guna2PictureBox1.Image;
            }
            set
            {
                guna2PictureBox1.Image = value;
            }
        }

        public Details()
        {
            InitializeComponent();
        }

        private void Details_Load(object sender, EventArgs e)
        {

        }
    }
}
