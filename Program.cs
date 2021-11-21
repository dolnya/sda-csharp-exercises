using System;
using System.Reflection.Metadata.Ecma335;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        //E22
        //Jesteś malarzem.
        //Twój klient chce żebyś mu namalował na ścianach koła(Circle) i kwadraty(Square).
        //Przekazał Ci listę wymiarów wszystkich kształtów do namalowania(Shape). W przypadku kół
        //znasz ich promień(radius), w przypadku kwadratów długość boku(side).
        //Musisz ustalić ile farby potrzebujesz, w tym celu musisz najpierw ustalić łączną powierzchnie
        //wszystkich kształtów.
        {


            double radius = 4.1212;
            int numberOfCircles = 4;
            double side = 4;
            int numberOfSquares = 4;


            double area = 0;
            Console.WriteLine($"Powieszchnia kół = {(CircleArea(radius) * numberOfCircles):F1}");
            Console.WriteLine($"Powieszchnia kwadratu = {(ReqArea(side) * numberOfSquares):F1}");
            area = (CircleArea(radius) * numberOfCircles) + (ReqArea(radius) * numberOfSquares);
            Console.WriteLine($"Powieszchnia wszystkiego = {(area):N}");

            ;
        }

        static double CircleArea(double radius)
        {
           return  radius * radius * 3.14159265359;
        }
        static double ReqArea(double side)
        {
            return side * side ;
        }
    }
}
