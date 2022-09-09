using ConsoleApp3;

namespace StrukturyDanychZadania
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Stworz liste kont
            var list = new List<Account>()
            {
                new Account (53200), 
                new Account (15230), 
                new Account (3253), 
                new Account (45300), 
                new Account (42100), 
                new Account (5350), 
                new Account (1230),
                new Account (1200), 
                new Account (800), 
                new Account (50),
            };

            //Wyswietl zawartosc tej lsity kont przy uzyciu string join
            Console.WriteLine(string.Join($",{Environment.NewLine}", list));
            Console.WriteLine("--------------------------------------------");
            //Posortuj te liste kont
            list.Sort();
            Console.WriteLine(string.Join($",{Environment.NewLine}", list));
            Console.WriteLine("--------------------------------------------");
            Comparison<Account> accountComparison = (a , b) => -decimal.Compare(a.Balance, b.Balance);
            list.Sort(accountComparison);
            Console.WriteLine("--------------------------------------------");
            list.Sort((a, b) => decimal.Compare(a.Balance, b.Balance));
            Console.WriteLine(string.Join($",{Environment.NewLine}", list));
            Console.WriteLine(string.Join($",{Environment.NewLine}", list));

            //metoda dla delegatu jest tym samym co obiekt dla klasy
            //NIE WOLNO UZYWAC JAKICHKOLWIEK PETLI, masz uzyc LINQ
            //wyswietl na konsole liczbe kont ktore maja mniej niz 1000
            var result = list.Where(x => x.Balance < 1000).Count();
            Console.WriteLine($"Liczba elementow {result}");


            //wyswietl na konsole tylko te konta na ktorych jest wiecej niz 10000 (metoda Where)

            //usun z listy te konta ktore maja miedzy 1000 a 2000  (wskazowka RemoveAll)

            //wyswietl na konsole tylko i wylacznie stany kont (wskazowka metoda Select)

            

        }
    }
}