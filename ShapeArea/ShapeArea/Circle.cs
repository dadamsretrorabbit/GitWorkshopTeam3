using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeArea
{
    class Circle
    {
        private double radius;
        public Circle()
        {

        }

        public void getArea()
        {
            Console.WriteLine("Enter the Radius for your circle: ");
            radius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Area is {0}", Math.Pow(radius, 2) * Math.PI);
        }
    }
}
