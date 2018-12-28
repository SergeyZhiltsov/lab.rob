using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labosnproginj2.ProductText
{
    class Product
    {
        public string readyText;

        public void Add(string part)
        {
            readyText += part;
        }
    }
}
