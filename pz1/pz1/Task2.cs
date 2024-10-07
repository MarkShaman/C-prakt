using System;
using System.Text.RegularExpressions;


namespace pz1
{
    internal class Task2
    {
        public void triangle()
        {
            double a = 5;
            double b = 5;
            double c = 5;

            double P = a + b + c;
            double p = (a + b + c) / 2;
            double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            string triangletype = TriangleType(a, b, c);

            if (IsTriangle(a, b, c)){
                Console.WriteLine($"perimetr:{P}");
                Console.WriteLine($"Ploshcha:{S}");
                Console.WriteLine($"Typ:{triangletype}");
            }

        }
        static bool IsTriangle(double a, double b, double c)
        {

            return a + b > c && a + c > b && b + c > a;

        }
        static string TriangleType(double a, double b, double c)
        {
            if (a == b && b == c)
            {
                return "рівносторонній";
            }
            else if (a == b || a == c || b == c)
            {
                return "рівнобедрений";
            }
            else
            {
                return "різносторонній";
            }

        }

     

    }
   
}
