using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_abhikadiya
{
    class Triangle
    {
        public double GetHypotenuse(double side1, double side2)
        {

            return Math.Round(Math.Sqrt(Math.Pow(side1, 2) + Math.Pow(side2, 2)), 2);
        }
    }
}
