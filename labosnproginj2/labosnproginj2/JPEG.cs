using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labosnproginj2
{
    public partial class JPEG : Form
    {
        public JPEG()
        {
            InitializeComponent();
        }
        private static JPEG single = null;

        public static JPEG Instance()
        {

            single = new JPEG();
            return single;
        }

        public static JPEG Close()
        {

            if (single != null)
            {
                single = null;
            }
            return single;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void JPEG_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FMCreator creator = new JPEGCreator();
            FMProduct product = creator.FactoryMethod();
            pictureBox1.Image = Image.FromFile(product.CreateForm());
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                pictureBox1.Image.Dispose();
                pictureBox1.Image = null;
            }
        }

        private void JPEG_Load_1(object sender, EventArgs e)
        {

        }
    }

}
