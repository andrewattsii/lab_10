using System;
using System.Collections.Generic;
using System.Text;

namespace lab_10
{
    class Circle
    {

        private double Radius;

        public Circle(double radius)
        {
            this.Radius = radius;
        }
        public double CaclculatorCircumfrance()
        {
           return  2 * Math.PI * Radius;
        }
        public double CalculatorArea()
        {
            return Math.PI * Radius * Radius;
        }



    }
}
