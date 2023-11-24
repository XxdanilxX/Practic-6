using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic_6
{
    internal class TSquare
    {
        public double sideLength;

        public TSquare()
        {
            sideLength = 0;
        }

        public TSquare(double side)
        {
            if (side > 0)
                sideLength = side;
            else
                throw new ArgumentException("Довжина сторони повинна бути більше 0.");
        }

        public TSquare(TSquare square)
        {
            sideLength = square.sideLength;
        }

        public void Input()
        {
            Console.Write("Введіть довжину сторони: ");
            sideLength = Convert.ToDouble(Console.ReadLine());
        }

        public void Display()
        {
            Console.WriteLine($"Квадрат зі стороною {sideLength}");
        }

        public double Area()
        {
            return sideLength * sideLength;
        }

        public double Perimeter()
        {
            return 4 * sideLength;
        }

        public bool Equals(TSquare otherSquare)
        {
            return this.sideLength == otherSquare.sideLength;
        }

        public static TSquare operator +(TSquare square1, TSquare square2)
        {
            return new TSquare(square1.sideLength + square2.sideLength);
        }

        public static TSquare operator -(TSquare square1, TSquare square2)
        {
            double result = square1.sideLength - square2.sideLength;
            if (result > 0)
                return new TSquare(result);
            else
                throw new ArgumentException("Різниця сторін менше або дорівнює 0.");
        }

        public static TSquare operator *(TSquare square, double multiplier)
        {
            return new TSquare(square.sideLength * multiplier);
        }
    }
}
