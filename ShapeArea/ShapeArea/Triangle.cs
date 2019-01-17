using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeArea
{
    class Class1
    {
        private double Base;
        private double Height;

        public void setDimensions(double _base, double _height)
        {
            this.Base = _base;
            this.Height = _height;
        }

        public void getArea()
        {
            double b, h;
            double area;

            Console.WriteLine("Insert the triangle's height: ");
            h = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Insert the triangle's base: ");
            b = Convert.ToDouble(Console.ReadLine());

            setDimensions(b, h);

            area = (0.5 * Base) * Height;

            Console.WriteLine("The triangle's area is : "+area);
        }
    }
}
