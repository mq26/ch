using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods
{
    class Print
    {
        public static void print_x(List<double> x, string name_method)
        {
            Console.WriteLine(name_method + ": ");
            foreach(double point in x)
            {
                Console.WriteLine(point);
            }
        }
    }
}
