using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        //    E09

        //Dla numeru PESEL podanego jako tekst, sprawdź, czy ma on poprawną cyfrę kontrolną zgodnie z
        //algorytmem podanym na stronie
        //pl.wikipedia.org/wiki/PESEL#Cyfra_kontrolna_i_sprawdzanie_poprawności_numeru
        //Liczby, przez które mnożymy poszczególne cyfry numeru PESEL nazywają się wagami.
        //Utwórz tablicę, w której zapiszesz te wagi i wykorzystaj tę tablicę do sprawdzenia poprawności
        //cyfry kontrolnej.
        {
            

            // Zadanko nieskończone
            int[] number = { 5, 5, 0, 3, 0, 1, 0, 1, 1, 9, 3 };
            int[] values = { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3, 1};
            int[,] control = new int[5, 12] { { 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92 }, { 01, 02, 03, 04, 05, 06, 07, 08, 09, 10, 11, 12 }, { 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32 }, { 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52 }, { 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72 } };
            int temValue = 1;

            for (int i = 0; i < number.Length; i++)
            {
                temValue += number[i] * values[i];
            }

            Console.WriteLine(temValue);
            Console.WriteLine(control[1,2]);
            if (control[1,2]==temValue)
            {
                Console.WriteLine("Correct");
            }
        }
    }
}
