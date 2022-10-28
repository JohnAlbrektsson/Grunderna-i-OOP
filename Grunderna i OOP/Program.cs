using System;

namespace CircleArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circleA = new Circle(5);
            Console.WriteLine("Arean av en cirkel med radie 5 är {0}", circleA.getArea());
            Console.WriteLine("Omkretsen av en cirkel med radie 5 är {0}", circleA.Omkrets());
            Console.WriteLine("----------------");
            Circle circleB = new Circle(6);
            Console.WriteLine("Arean av en cirkel med radie 6 är {0}", circleB.getArea());
            Console.WriteLine("Omkretsen av en cirkel med radie 6 är {0}", circleB.Omkrets());
            Console.WriteLine("------------------");


            Triangle trianglea = new Triangle(4, 7, 10, 5);
            Console.WriteLine("Arean av triangeln är {0}", trianglea.getArea());
            Console.WriteLine("Omkretsen för triangeln är {0}", trianglea.Omkrets());
        }
    }
}
