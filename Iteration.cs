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
            
            foreach (double[] limit in eq.limits)
            {
                xi = (limit[1]);
                short valid = eq.iterPrChecker(xi);
                 
                   if(valid == -1)
                    {
                        valid = eq.iterPrChecker(limit[0]);
                        if(valid != -1)
                        {
                             xi = limit[0];
                        }
                    } 
                    do
                    {
                        x0 = xi; 
                  
                    if (valid == 0)
                    {
                        xi = eq.itCalculate(x0);
                    }
                    else if (valid == 1)
                    {
                        xi = eq.itCalculateMod(x0);
                    } 

                    else if (valid == 3)
                    {
                        xi = eq.itCalculateSecondMode(x0);

                    }
               
                } while (Math.Abs(x0 - xi) >= eq.e);
                    eq.xVal.Add(xi); 
                }
                Print.print_x(eq.xVal, "Iteration");
            } 
        }
     }

