using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static private char[] leetLetters = { '4', '3', '1', '0', '$' };
        static private char[] naturalLetters = { 'a', 'e', 'i', 'o', 's' };
        public static void Main(string[] args)
        //E07
        //Pobawmy się w hakerów z lat osiemdziesiątych;)
        //https://www.urbandictionary.com/define.php?term=l33t
        //Napisz funkcję, która „zakoduje” podany napis w „l33t speak”, tzn. zamieni odpowiednio litery
        //(zarówno małe jak i wielkie) :
        //A = 4
        //E = 3
        //I = 1
        //O = 0 (zero)
        //S = $
        //Przykładowo: dla napisu „Asia” otrzymamy „4$14”.
        //Napisz również funkcję, która „odkoduje” napis(czyli z „4$14” otrzymamy „asia”).
        //Czy potrafisz w swoim rozwiązaniu wykorzystać dwie poniższe tablice?
        //char[] leetLetters = { '4', '3', '1', '0', '$' };
        //char[] naturalLetters = { 'a', 'e', 'i', 'o', 's' };
        {

            string password1 = ("133t speak");
            string password2 = ("4$14");
            Console.WriteLine(Code(password1));
            Console.WriteLine(DeCode(password2));

        }

        // Cedits Emil :)
        static string Code(string Password)
        {
            string str = Password;

            string result = "";

            foreach (char letter in Password)
            {
                result += letter;

                for (int i = 0; i < naturalLetters.Length; i++)
                {
                    if (letter == naturalLetters[i])
                    {
                        result = result.Remove(result.Length - 1, 1);
                        result += leetLetters[i];
                        break;
                    }
                }
            }

            return result;
        }
        static string DeCode(string Password)
        {
            string result = "";

            foreach (char letter in Password)
            {
                result += letter;

                for (int i = 0; i < leetLetters.Length; i++)
                {
                    if (letter == leetLetters[i])
                    {
                        result = result.Remove(result.Length - 1, 1);
                        result += naturalLetters[i];
                        break;
                    }
                }
            }

            return result;

        }
    }
}
