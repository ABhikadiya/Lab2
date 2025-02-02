﻿using System;
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

        public double GetArea(double side1, double side2)
        {
            return 0.5 * (side1 * side2);
        }

        public double GetAngle(double angle1, double angle2)
        {
            return 180 - (angle1 + angle2);
        }
    }
}
