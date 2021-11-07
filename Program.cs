using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)

            //E05

        //Napisz funkcję, która będzie wyliczała wartość funkcji silnia dla argumentu podanego przez
        //użytkownika.
        //Funkcja silnia jest definiowana w następujący sposób:
        //en.wikipedia.org/wiki/Factorial
        {
            Console.WriteLine("Silnia x!");
            int value = Convert.ToInt32(Console.ReadLine());
            Power(value);
        }

        static int Power(int Value)
        {
            int sum = 1;
            if (Value <0 )
            {
                Console.WriteLine("Zła wartość");
                sum = 0;
                
            }
            if (Value == 0)
            {
                    sum =1;
                Console.WriteLine(sum);
            }

            for (int i =0; i<Value; i++)
            {
                sum *= (Value - i);
            }
            Console.WriteLine(sum);
            return sum;
        }
    }
}
