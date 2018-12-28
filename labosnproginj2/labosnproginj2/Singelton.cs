using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labosnproginj2
{
    class Singleton
    {
        private Singleton() { }

        private static readonly Lazy<Singleton> lazy =
            new Lazy<Singleton>(() => new Singleton());

        public static Singleton Ini { get { return lazy.Value; } }
    }
}
