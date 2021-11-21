using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        //E21
        //Rozwiąż zadanie E20 bez wykorzystywania dziedziczenia(utwórz jedną klasę BasicAccount).
        //Wskaż zalety i wady każdego z podejść.
        {
            Bank bank = new Bank();
            Account account = new Account(1500M);
            account.IncreaseBalance(500);
            SavingAccount savingAccount = new SavingAccount(4000, 100);
            savingAccount.IncreaseInterest(50);

            bank.AddAccount(account);
            bank.AddAccount(savingAccount);

            Console.WriteLine(bank.GetValue());
        }
    }
    }
}
