using System;
using AreaCalc;

class Program
{
    static void Main(string[] args)
    {
        Triangle trg = new Triangle(3, 2, 4);
        Shape crc = new Circle(1);

        Console.WriteLine("{0}\n{1}\n{2}", trg.Area(), crc.Area(), trg.IsRightTriangle());
        Console.ReadKey();
    }
}
