using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods
{
    public class Iteration
    {
        Equalation eq;
        public Iteration()
        {
            eq = new Equalation();
            start();
        }

        private void start()
        {
            double xi = 0;
            double x0 = 0;
            int counter = 0;
            foreach (double[] limit in eq.limits)
            {
                xi = (limit[0]);
                counter = 0;
                    do
                    {
                        x0 = xi;
                      
                    xi = eq.iterat(x0, limit[2]);
                    counter++;
                } while (Math.Abs(x0 - xi) >= eq.e);
                eq.xVal.Add(xi);
                eq.xVal.Add(counter);
                }
                Print.print_x(eq.xVal, "Iteration");
            } 
        }
     }

