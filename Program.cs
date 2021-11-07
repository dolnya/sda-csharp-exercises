using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        //E11
        //Napisz funkcję, która w zależności od przekazanych parametrów wydrukuje spersonalizowany tekst
        //jak poniżej.
        //W nawiasach kwadratowych oznaczyłem elementy, które mają być spersonalizowane:
        //[Imię Drugie_Imię Nazwisko]
        //[ul.Nazwa_ulicy Numer / numer_mieszkaniaMiasto]
        //[Szanowna Pani | Szanowny Panie | Droga Użytkowniczko | Drogi Użytkowniku]
        //Zapraszamy[Pana | Panią | Cię] serdecznie na otwarcie naszego sklepu!
        //Powitamy[Pana | Panią | Cię][kieliszkiem szampana | kubkiem gorącej czekolady].
        //[I zapraszamy do gry w bingo]
        //[do zobaczenia | czekamy na Pana | czekamy na Panią | z wyrazami szacunku]
        //Założenia:
        //- w zależności od płci i wieku wyświetlamy odpowiednie powitanie i później formy(Pan lub Pani, a
        //dla niepełnoletnich Ty i Użytkowniku lub Użytkowniczko
        //- dla niepełnoletnich czekolada, dla pełnoletnich szampan
        //- gra w bingo tylko dla seniorów (powyżej 60 lat)
        //- zakończenie – „z wyrazami szacunku” dla seniorów, pozostałe w zalezności od płci i wieku
        //- płeć powinna być przekazana jako parametr funkcji, możesz np.użyć odpowiednio liter ‘m’ i ‘k’
        //lub liczb i założyć, że np. 1 to kobieta, 2 to mężczyzna, lub jako zmienna logiczna, np.isFemale
        //- pamiętaj, że nie każdy ma drugie imię i numer mieszkania.
        {
            Console.WriteLine("Proszę wpisać imię, drugie imie i nazwisko oraz wiek");
            string name = Console.ReadLine();
            string secname = Console.ReadLine();
            string surname = Console.ReadLine();
            int age = Convert.ToInt32(Console.ReadLine());
            bool sex = true; // false = kobieta  true mężczyzna
            if (name.EndsWith("a"))
            {
                sex = false;
            }

            Console.WriteLine("Prosze podać nazwę ulicy i number domu i mieszkania");
            string street = Console.ReadLine();
            string number = Console.ReadLine();
            string flat = Console.ReadLine();
            
            Console.Write(sex);
            
            
            Console.WriteLine($"{name} {secname} {surname}");
            Console.WriteLine($"ul.{street} {number}/{flat}");
            if (sex == true) // mężczyna
            {
                if (age > 18) // pełnoletni
                {
                    Console.WriteLine($"Szanowny Panie {surname}");
                    Console.WriteLine("Zaprazamy Pana serdecznie na otwarcie naszego sklepu!");
                    Console.WriteLine("Powitamy Pana kieliszkiem szampana.");
                    if (age > 60)
                    {
                        Console.WriteLine("I zapraszamy do gry w bingo.");
                        Console.WriteLine("Z wyrazami szacunku.");
                    }
                    else
                    {
                        Console.WriteLine("Czekamy na Pana.");
                    }
                }
                else
                {
                    Console.WriteLine($"Drogi Użytkowniku {name}");
                    Console.WriteLine("Zaprazamy cię serdecznie na otwarcie naszego sklepu!");
                    Console.WriteLine("Powitamy cię kubkiem gorączej czekolady.");
                    Console.WriteLine("Do zobaczenia");
                }
            }
            else // kobieta
            {
                if (age > 18) // pełnoletni
                {
                    Console.WriteLine($"Szanowny Pani {surname}");
                    Console.WriteLine("Zaprazamy Panią serdecznie na otwarcie naszego sklepu!");
                    Console.WriteLine("Powitamy Panią kieliszkiem szampana.");
                    if (age > 60)
                    {
                        Console.WriteLine("I zapraszamy do gry w bingo.");
                        Console.WriteLine("Z wyrazami szacunku.");
                    }
                    else
                    {
                        Console.WriteLine("Czekamy na Panią.");
                    }
                }
                else
                {
                    Console.WriteLine($"Drogi Użytkowniczko {name}");
                    Console.WriteLine("Zaprazamy cię serdecznie na otwarcie naszego sklepu!");
                    Console.WriteLine("Powitamy cię kubkiem gorączej czekolady.");
                    Console.WriteLine("Do zobaczenia");
                }
            }
            
        }
    }
}
