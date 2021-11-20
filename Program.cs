using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        //E17
        //Utwórz klasę reprezentującą zamówienie(rachunek) w sklepie(Order).
        //Niektóre z pozycji zamówienia(items) posiadają opakowanie(package) i musiałeś zapłacić kaucję
        //(bail) za nie.
        //Dla każdej z pozycji zamówienia wyświetl szczegółowe informacje na jej temat, a następnie
        //podsumowanie całego zamówienia (czyli sumę wartości poszczególnych pozycji zamówienia).
        //Stwórz klasę do przechowywania informacji o określonej pozycji zamówienia(OrderItem), która
        //będzie przechowywała: nazwę produktu(product name), ilość(quantity) i cenę jednostkową(unit
        //price).
        //Utwórz konstruktor i dwie metody:
        //- GetValue – która wylicza wartość danej pozycji zamówienia(ilość x cena jednostkowa),
        //- ToString – która przekształca pozycję zamówienia do łańcucha tekstowego, wyświetlając jej
        //właściwości oraz wartość, czyli dla przykładu: „Chleb, cena: 3.50 PLN, 5 szt, wartość: 17.50 PLN”.
        //Utwórz klasę dla pozycji zamówienia z kaucją(OrderItemWithPackage), która będzie
        //przechowywała te same informacje co „zwykła” pozycja zamówienia, a dodatkowo informację o
        //rodzaju opakowania(package name) i cenie opakowania(package price).
        //Utwórz konstruktor i dwie metody:
        //- GetValue – która wylicza wartość tej pozycji zamówienia(ilość x cena jednostkowa + ilość x cena
        //opakowania),
        //- ToString – która przekształca pozycję zamówienia do postaci łańcucha tekstowego, wyświetlając
        //jej właściwości oraz wartość, czyli dla przykładu: „Mleko, cena: 2.20 PLN, opakowanie: butelka,
        //cena opakowania: 1 PLN, 5 szt, wartość: 16 PLN”.
        //Wyświetl sumę wartości wszystkich pozycji zamówienia, czyli dla przykładu: „Wartość
        //zamówienia: 33.5 PLN”.
        {
        }
    }
}
