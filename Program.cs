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
        {
            MyPoint first = new MyPoint(4,2);
            MyPoint second = new MyPoint(6,6);

            LineSegment lineSegment1 = new LineSegment(first, second);
            Console.WriteLine(lineSegment1.Length());
            LineSegment lineSegment2 = new LineSegment(2, 6, 3, 1);
            Console.WriteLine(lineSegment2.Length());
        }
    }
}
