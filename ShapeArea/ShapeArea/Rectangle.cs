using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Rectangle
    {
        private double _base;
        private double _height;

        public void getArea()
        {
            double area = 0.0;
            Console.WriteLine("Enter base: ");
            _base = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter height: ");
            _height = Convert.ToDouble(Console.ReadLine());
            area = _base * _height;
            Console.WriteLine("Your area is: ", area);
        }
        /*
        public void setDimensions(double b, double h)
        {
            this._base = b;
            this._height = h;
        }
        public Rectangle()
        {
            this._base = 0.0;
            this._height = 0.0;
        }
        public Rectangle(double b, double h)
        {
            this._base = b;
            this._height = h;
        }
        */
    }
}
