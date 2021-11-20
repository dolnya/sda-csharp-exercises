using System;
using System.Collections.Generic;

namespace sda_csharp_exercises
{
    class Program
    {
        static void PrintHello(Person person)
        {
            if (person.IsAdult())
            {
                Console.WriteLine("Welcome to liquor store");
            }
            else
            {
                Console.WriteLine("Welcome to toy store");
            }
        }
        static void Main(string[] args)
        //E14(realizuje trener)
        //Jesteś pracodawcą, który chce zorganizować imprezę firmową.
        //Potrzebujesz stworzyć listę uczestników – niektórzy z nich będą twoimi pracownikami, niektórzy
        //nie.
        //Wyświetl informację o wszystkich uczestnikach imprezy, jeżeli któryś uczestnik jest równocześnie
        //pracownikiem – wyświetl jego wynagrodzenie.

        {
            Person person1 = new Person("Jan","Kowalski",1999);
            Employee employee1 = new Employee("Adam","Nowak",2000,5000);
            Person person2 = new Employee("Joanna", "Kowalska", 2000, 5000);
            Person person3 = new Person("Adam", "Wielki", 2010);
            List<Person> people = new List<Person>();
            people.Add(person1);
            people.Add(employee1);
            people.Add(person2);
            people.Add(person3);
            foreach (Person p in people)
            {
                if (p is Employee)
                {
                    p.WhoAmI();
                    Console.WriteLine("Is Employee");
                }
                else if (p is Person)
                {
                    p.WhoAmI();
                    Console.WriteLine("Is Person");

                }
                else
                {
                    Console.WriteLine("No idea ?");
                }
                PrintHello(p);

            }
        }
    }

}
