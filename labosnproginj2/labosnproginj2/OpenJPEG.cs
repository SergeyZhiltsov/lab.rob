using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labosnproginj2
{
    class OpenJPEG : FMProduct
    {
        public override string CreateForm()
        {
            string line = "";
            using (OpenFileDialog opf = new OpenFileDialog() { Filter = "Image Files(*.JPEG)|*.JPEG|(*.PNG)|*.PNG|(*.BMP)|*.BMP|(*.JPG)|*.JPG|All files (*.*)|*.*", ValidateNames = true, Multiselect = false })
            {
                if (opf.ShowDialog() == DialogResult.OK)
                {
                    line = opf.FileName;
                }
            }
            return line;
        }

        public override void CloseForm()
        {

        }
    }
}
