 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods
{
    public class Bisection
    {
       private List<double> xVal = new List<double>();
       private List<double[]> limits = new List<double[]>();
       private double e;
       Equalation eq;

       public Bisection()
        {
            eq = new Equalation();
            limits = eq.limits;
            e = eq.e;
            startBis(); 
        }

        private void startBis()
        { 
            foreach(double[] limit in limits)
            {
                double val1 = 0;
                double val2 = 0;
                double c = 0; 
                int counter = 0;
                do
                {
                    val1 = eq.Calculate(limit[0]);
                    val2 = eq.Calculate(limit[1]);
                     
                    c = eq.Calculate((limit[1] + limit[0])/2); 
                    if (MoreThenZero(c) != MoreThenZero(val1))
                    {
                        limit[1] = (limit[1] + limit[0]) / 2; 
                    }
                     
                    else
                    {
                        limit[0] = (limit[1] + limit[0]) / 2;
                    }
                    counter++;
                } while (Math.Abs(limit[1] - limit[0]) >= e);
                xVal.Add((limit[1] + limit[0]) / 2);
                xVal.Add(counter); 

            }
            Print.print_x(xVal, "Bisection");
        }
         

        private bool MoreThenZero(double value)
        {
            return value > 0;
        }
    }
}
