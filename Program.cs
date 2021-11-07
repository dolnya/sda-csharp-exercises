using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        //Zadanko E04
        //Namaluj trójkąt z gwiazdek o zadanej liczbie linii.Dopełnij pod spodem odwróconym trójkątem tak
        //jak w przykładzie poniżej.Zwróć uwagę, że linia z maksymalną liczba gwiazdek jest tylko jedna.
        //Np.dla 3 linii:

        //*
        //**
        //***
        //**
        //*

        //Rozszerz zadanie tak, aby można było namalować trójkąt dowolonym znakiem zamiast gwiazdką.
        {
            Console.WriteLine("Wprowadz długość");
            int length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Wprowadz znak");
            string znak = Console.ReadLine();
            Triagnle(znak, length);
            
        }
        static void Triagnle(string Znak, int Length)
        {
            for (int i = 0; i < Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write($"{Znak}");
                }
                Console.WriteLine();
            }
            for (int i = Length; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write($"{Znak}");
                }
                Console.WriteLine();
            }
        }
        
    }
}
