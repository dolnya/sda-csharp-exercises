using System;
namespace sda_csharp_exercises
{
    class Program
    {
        public static void Main(string[] args)
            //E06
            //Dla podanego ciągu znaków oznaczającego hasło, sprawdź, czy spełnia on następujące warunki
            //złożoności hasła:
            //• długość co najmniej 6 znaków
            //• występują co najmniej jedna duża i jedna mała litera
            //• występuje co najmniej jedna cyfra
            //• występuje co najmniej jeden znak specjalny spośród następujących: &*$#
        {
            
            Console.WriteLine("Wprowadź hasło");
            string password = Console.ReadLine();
            PasswordCheck(password);
        }

        static void PasswordCheck(string password)
        {
            int minLenght = 6;
            string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string lowercase = "abcdefghijklmnopqrstuvwxyz";
            string digits = "0123456789";
            string specialChars = "&*$#";
            
            if ((password.Length > minLenght) && Contains(password,uppercase) && Contains(password, lowercase) && Contains(password, digits) && Contains(password, specialChars))
            {
                Console.WriteLine("Ok");
            }
            else
            {
                Console.WriteLine("Not Ok");
            }

            return;
        }
        public static bool Contains(string target, string list)
        {
            return target.IndexOfAny(list.ToCharArray()) != -1;
        }
    }
}
