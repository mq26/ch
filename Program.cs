using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods
{
    class Program
    {
        static void Main(string[] args)
        {
             
              Bisection bis = new Bisection();
              Horda hord = new Horda();
              Newtone newtone = new Newtone();
              Iteration it = new Iteration();
             /*
            Equalation eq = new Equalation();
            Console.WriteLine(eq.Calculate(3.5)); 
          */
            Console.Read();
        }
    }
}
