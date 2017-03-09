using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNDepend
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var c = new MyClass(true);

            var b = c.Method1(9);

            c.Method2();
        }
    }
}
