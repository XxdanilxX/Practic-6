using System;
namespace Practic_6
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Сторона квадрата 1:");
            TSquare square1 = new TSquare(Convert.ToDouble(Console.ReadLine()));
            square1.Display();
            Console.WriteLine($"Площа: {square1.Area()}");
            Console.WriteLine($"Периметр: {square1.Perimeter()}");
            Console.WriteLine("Сторона квадрата 2:");
            TSquare square2 = new TSquare(Convert.ToDouble(Console.ReadLine()));
            square2.Display();
            Console.WriteLine($"Площа: {square2.Area()}");
            Console.WriteLine($"Периметр: {square2.Perimeter()}");

            Console.WriteLine($"Чи рівні квадрати? {square1.Equals(square2)}");

            TSquare sumSquare = square1 + square2;
            sumSquare.Display();
            Console.WriteLine($"Площа суми: {sumSquare.Area()}");

            try
            {
                TSquare diffSquare = square1 - square2;
                diffSquare.Display();
                Console.WriteLine($"Площа різниці: {diffSquare.Area()}");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }

            TSquare scaledSquare = square1 * 2;
            scaledSquare.Display();
            Console.WriteLine($"Площа масштабованого квадрата: {scaledSquare.Area()}");

            Console.WriteLine("\nСторона куба 1:");
            TCube cube1 = new TCube(Convert.ToDouble(Console.ReadLine()));
            cube1.Display();
            Console.WriteLine($"Об'єм: {cube1.Volume()}");
            Console.WriteLine("\nСторона куба 2:");
            TCube cube2 = new TCube(Convert.ToDouble(Console.ReadLine()));
            cube2.Display();
            Console.WriteLine($"Об'єм: {cube2.Volume()}");
        }
    }
}