using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using labosnproginj2.Builder;

namespace labosnproginj2.Director
{
    class RTFReader
    {
        readonly ITextBuilder builder; // builder

        public RTFReader(ITextBuilder builder)
        {
            this.builder = builder;
        }

        public void BuildText(string text)
        {
            builder.GetText(text);
        }
    }
}
