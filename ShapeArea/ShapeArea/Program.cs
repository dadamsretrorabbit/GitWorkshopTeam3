using System;

namespace ShapeArea
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Square sqr1 = new Square();
            sqr1.getArea();

            Triangle tr1 = new Triangle();
            tr1.getArea();

            Rectangle rec1 = new Rectangle();
            rec1.getArea();

            Circle cir1 = new Circle();
            cir1.getArea();

            //Parrallelogram par1 = new Parrallelogram();
            //par1.CalculateArea();
        }
    }
}
