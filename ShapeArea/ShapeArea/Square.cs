using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeArea
{
    class Square
    {

        private double length;
        public void getArea()
        {
            Console.WriteLine("Provide the length for your square:");
            length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Your area of square is : " + (Math.Pow(length, 2)));
        }

    }
}
