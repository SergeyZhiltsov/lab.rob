using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labosnproginj2
{
    class JPEGCreator : FMCreator
    {
        public override FMProduct FactoryMethod()
        {
            return new OpenJPEG();
        }

    }
}
