using System;
using System.Linq;
namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            E08

            Dla podanej tablicy liczb naturalnych wypisz tylko niepowtarzające się liczby.
            Przykład:
            int[] numbers = { 2, 5, 1, 2, 5 };
            Wynik:
            2 5 1
            Podpowiedź:
            zauważ, że w tablicy będą tylko liczby naturalne, czyli >= 0.Duplikat możesz więc nadpisać
            dowolną liczbą ujemną.
            */
            int[] numbers = { 2, 5, 1, 2, 5 };
            int[] tem = new int[numbers.Length];
            int i = 0;

            //Credits Marek 
            foreach (char c in numbers)
            {
                if (!tem.Contains(numbers[i]))
                
                    tem[i] = numbers[i];
                else
                    tem[i] = -1;
                
                i++;
            }
            foreach (int c in tem)
            {
                if (c != -1)
                    Console.Write($"{c} ");
            }
        } 
    }
}
