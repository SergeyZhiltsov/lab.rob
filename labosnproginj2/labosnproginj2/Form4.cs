using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using labosnproginj2.Builder;
using labosnproginj2.ProductText;
using labosnproginj2.Director;
using System.IO;

namespace labosnproginj2
{
    public partial class RTF : Form
    {
        public RTF()
        {
            InitializeComponent();
        }

        private static RTF single = null;

        public static RTF Instance()
        {

            single = new RTF();
            return single;
        }

        public static RTF Close()
        {

            if (single != null)
            {
                single = null;
            }
            return single;
        }

        private void RTF_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void RTF_Load_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            using (OpenFileDialog opf = new OpenFileDialog() { Filter = "Rich Text Format|*.rtf", ValidateNames = true, Multiselect = false })
            {
                HTML hConverter = new HTML(); // строители
                PlainText pConverter = new PlainText();
                if (opf.ShowDialog() == DialogResult.OK)
                {
                    hConverter.Reset();
                    pConverter.Reset();
                    RTFReader director = new RTFReader(hConverter); // иниц. директора

                    string text = System.IO.File.ReadAllText(opf.FileName);
                    richTextBox1.Rtf = text;
                    text = richTextBox1.Rtf; // переопределение rtf текста (удаление MS заголовков и т.п.)
                    director.BuildText(text);
                    Product htmlText = hConverter.GetProduct();
                    richTextBox2.Text = htmlText.readyText;

                    director = new RTFReader(pConverter); // обращение к другому строителю
                    director.BuildText(text);
                    Product plainText = pConverter.GetProduct();
                    richTextBox1.Text = plainText.readyText;
                }
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string dir = @"C:\\Users\\hasep\\Desktop\\labosnproginj2\\log" + DateTime.Today.ToString("dd_MMM_yy");
            string path = @"C:\\Users\\hasep\\Desktop\\labosnproginj2\\log" + DateTime.Today.ToString("dd_MMM_yy") + "\\" + DateTime.Now.ToString("HH.mm.ss") + ".html";
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            if (!File.Exists(path))
            {
                using (File.Create(path)) ;
                richTextBox2.SaveFile(path, RichTextBoxStreamType.UnicodePlainText);
                MessageBox.Show("Saved!", "OK");
            }
        }
    }
}
