using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        // E03
        //Napisz funkcję tworzącą ciąg arytmetyczny o podanych: długości, pierwszym elemencie, różnicy ciągu.
        {
            Console.WriteLine("Wpis długość");
            int lenght = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Wpisz pierwszy element");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Wpisz różnicę ciągu");
            int element = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ciąg =>");
            

            for (int i =0; i<lenght; i++)
            {
                Console.Write($" {first+(i*element)}");
            }
                
        }
    }
}
