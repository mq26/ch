using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods
{
    public class Newtone
    {
        Equalation eq;

        public Newtone()
        {
            eq = new Equalation();
            start();
        }

        public void start()
        {
            double x0 = 0;
            double xi = 0;
            foreach (double[] limit in eq.limits)
            {
                
                xi = findX(limit[0], limit[1]); 
                if(x0 != -9999)
                {
                    do
                    {
                        x0 = xi;
                        xi = x0 - (eq.Calculate(x0)) / eq.FirstPr(x0);

                        Console.WriteLine(" x: " + x0 + " y " + limit[1] + " c: " + xi);
                    } while (Math.Abs((eq.Calculate(x0)) / eq.FirstPr(x0)) >= eq.e);
                    eq.xVal.Add(xi);
                }
                
            }
            Print.print_x(eq.xVal, "Newtone");
        }

        public double findX(double x, double y)
        {
            if(checkforzero(x))
            {
                return x;
            }
            else if(checkforzero(y))
            {
                return y;
            }
            return x;
        }

        public bool checkforzero(double x)
        {
            if(eq.SecondPr(x) * eq.Calculate(x) >  0)
            {
                return true;
            }
            return true;
        }
     }
}
