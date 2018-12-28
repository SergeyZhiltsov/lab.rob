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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
               public static int count = 0;
    
        private void добавитьФормуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (count < 3)
            {
                IsMdiContainer = true;
                Form1 f = Form1.Instance();
                f.MdiParent = this;
                f.Show();
                f.Activate();
                count++;
            }
            else
            {
                Form1 f = Form1.Close();
                MessageBox.Show("Максимальное количество окон - 3");
            }
        }

        private void добавитьРисунокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (count < 10)
            {
                JPEG f = JPEG.Instance();
                f.MdiParent = this;
                f.Show();
                f.Activate();
                count++;
            }
            else
            {
                JPEG f = JPEG.Close();

            }
        }

        private void rTFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (count < 10)
            {
                RTF f = RTF.Instance();
                f.MdiParent = this;
                f.Show();
                f.Activate();
                count++;
            }
            else
            {
                RTF f = RTF.Close();

            }
        }
    }
}
