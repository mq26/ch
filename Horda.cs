using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods
{
    public class Horda
    {

       
        Equalation eq;  
        private bool faPr = false;

        public Horda()
        {
            eq = new Equalation();

            StardHord();
        }

        private bool Mult(double val)
        {
            double f = eq.Calculate(val);
            double p = eq.SecondPr(val);
            if (f*p < 0)
            {
                return false;
            }
            else 
            {
                return true;
            }
        }

        public void StardHord()
        {
            double fval = 0;
            foreach (double[] limit in eq.limits)
            {

                double xi = 0;
                double xik = 0;
                faPr = Mult(limit[0]);
                
                if(faPr)
                {
                    xik = limit[1];
                    xi = xik;
                    fval = eq.Calculate(limit[0]);
                }
                else
                {
                    xik = limit[0];
                    xi = xik;
                    fval = eq.Calculate(limit[1]);
                }
                do
                {
                    xi = xik;
                    if (faPr)
                    {
                        
                        xik = More(limit[0], xi, fval); 
                    }
                    else
                    {
                        xik = Less(limit[1], xi, fval);
                     
                        
                    }
                    Console.WriteLine("X: " + xi + " Value: " + xik);
                } while (Math.Abs(xi - xik) >= eq.e);
                eq.xVal.Add(xik);
            }

            Print.print_x(eq.xVal, "Hord");
        }

        private bool MoreThenZero(double value)
        {
            return value > 0;
        }

        public double Less(double a, double xk, double fa)
        {
            double value = a - (fa * (xk - a)) / (eq.Calculate(xk) - fa);
            return value;
        }

        public double More(double b, double xk, double fb)
        {
            double value = xk - (eq.Calculate(xk) * (b - xk)) / (fb - eq.Calculate(xk));
            return value;
        }
    }
}
