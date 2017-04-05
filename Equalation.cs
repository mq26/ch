using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods
{
    public class Equalation
    {
        public List<double> xVal = new List<double>();
        public List<double[]> limits;
        private double E = 0.001;
        public short whichAlg = 8;
        public double e { get; set; } 
        private List<double[]> Limits = new List<double[]>();

        public Equalation()
        {
            initLimit();
            this.e = E;
            this.limits = Limits;

        }
        private void initLimit()
        {
            Limits.Add(new double[] { 3, 4 });
        //  Limits.Add(new double[] { 0, 1 });
         //  Limits.Add(new double[] { -4, -3 }); 
           // Limits.Add(new double[] { 1, 1.5 });
        }

        public double Calculate(double x)
        {
           double value = x * x * x - 12 * x + 6; // уравнение   
           return value;
        }

        public double itCalculateMod(double x)
        {

            double value = Math.Pow((x * x * x + 6) / 12, 1d / 3);
           // double value = (x * x * x + 6) / 12; // уравнение   
            return value;
        }

        public double itCalculate(double x)
        {
            double value = (x * x * x + 6) / 12;

            Console.WriteLine("X: " + x + " Value: " + value);
            // уравнение   
            return value;
        }

        public double itCalculateSecondMode(double x)
        {
            double a = -6 / (x * x);
            double value = (12 / (x) - 6 / (x * x));
         
            return value; 
        }
         

        public short iterPrChecker(double x)
        {
            if (x * x / 4 < 1)
            {
                return 0;
            }

            double c = Math.Pow((x * x * x + 6) / 12, -2d / 3) * x * x / 4;
            if (Math.Abs(c) < 1)
            {
              return 1;
            } 
            c = Math.Abs(-12 * Math.Pow(x, -2) + 12 * Math.Pow(x, -3));
            if (c < 1 )
            {
                return 3;
            } 
          
           return -1;
        }

        public double FirstPr(double x)
        {
            return 3 * x * x - 12;
        }

        public double SecondPr(double x)
        {
            return 6 * x;
        } 

        public double phi(double x)
        {
            return x + 2*(x * x * x - 12 * x + 6);
        }

    }
}
