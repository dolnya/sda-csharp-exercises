using System;
using System.ComponentModel;
using System.Threading.Channels;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        //Programowanie obiektowe – inne przypadki
        //E23
        //Utwórz klasę reprezentującą punkt(MyPoint), która będzie miała dwie właściwości: x i y.
        //Utwórz klasę reprezentującą linię na płaszczyźnie(LineSegment), która będzie zawierała
        //informację o dwóch obiektach punktach(reprezentujących początek i koniec linii) i będzie
        //umożliwiała wyliczenie jej długości(Length).
        //Utwórz dwa konstruktory:
        //- jeden pobierający dwa punkty,
        //- drugi cztery wartości liczbowe reprezentujące współrzędne tych punktów.
        //Do wyliczania długości linii warto skorzystać z poniższej informacji:

        //E24
        //Rozwijając zadanie E23, utwórz klasę MyPoint3D, która będzie też przechowywała współrzędną: z.
        //Co zmienisz w klasie LineSegment aby stworzyć linię w przestrzeni trójwymiarowej?
        //Jak zmienisz wyliczanie długości linii aby obejmowała również linie w przestrzeni
        //trójwymiarowej?
        //Do wyliczania długości linii 3D warto skorzystać z poniższej informacji:

        //Podpowiedź: może wato dodać polimorficzną metodę GetDistanceFromPoint(MyPoint point) do
        //klasy MyPoint i przedefiniować w klasie MyPoint3D?


        {
            MyPoint first = new MyPoint(4,2);
            MyPoint second = new MyPoint(6,6);
            MyPoint3D first3D = new MyPoint3D(4, 2,45);
            MyPoint3D second3D = new MyPoint3D(6, 6,12);
            LineSegment lineSegment1 = new LineSegment(first3D, second3D);
            LineSegment lineSegment2 = new LineSegment(2, 6, 3, 1,2,5);
           
            Console.WriteLine(lineSegment1.Length());
            Console.WriteLine(lineSegment2.Length());
        }
    }
}
