using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        //E14(realizuje trener)
        //Jesteś pracodawcą, który chce zorganizować imprezę firmową.
        //Potrzebujesz stworzyć listę uczestników – niektórzy z nich będą twoimi pracownikami, niektórzy
        //nie.
        //Wyświetl informację o wszystkich uczestnikach imprezy, jeżeli któryś uczestnik jest równocześnie
        //pracownikiem – wyświetl jego wynagrodzenie.
        //{
        //    Person person = new Person();
        //    person.WhoAmI();
        //    person.FirstName = "Jan";
        //    person.LastName = "Kowalski";
        //    person.YearOfBirth = 1981;
        //    Console.WriteLine(person.IsAdult());
        //}
        {
            Person person = new Person()
            {
                FirstName = "Jan",
                LastName = "Kowalski",
                YearOfBirth = 1981,

            };


            Employee employee = new Employee();
            {
                employee.FirstName = "Andrzej";
                employee.LastName = "Kowalak";
                employee.YearOfBirth = 1941;
                employee.Salary = 2000;
            };
        }

    }
}
