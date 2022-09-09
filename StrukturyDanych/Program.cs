namespace StrukturyDanych
{
    public class Program
    {
        static void Main(string[] args)
        {
            // List - elementy wewnatrz sa w takiej kolejnosci jak je powstawiales
            // Set - kolejnosc elementow w przypadku HashSeta nie jest gwarantowana
            // w przypadku SortedSet decyduje o nim porzadek naturalny badz imeplementacja
            // interfejsu IComparable?
            // Dictionary (odpowiednik Map z Java)
            // List
            var list1 = new List<int>();
            var list2 = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };
            Console.WriteLine(string.Join(",", list2));
            //wypisz liste list 2 na konsole przy uzyciu foreach
            foreach (var element in list2)
            {
                Console.WriteLine(element + ", ");
            }
            Console.WriteLine();
            list2.Add(1);
            list2.AddRange(new List<int> { 2, 4, 4 });
            Console.WriteLine(string.Join(",", list2));
            list2.Insert(1, 10000);
            Console.WriteLine(string.Join(",", list2));
            list2[1] = 99999;
            Console.WriteLine(string.Join(",", list2));
            Console.WriteLine(list2[10]);

            // Set
            //zobacz sobie sam w wolnym czasie jakie tam sa metody
            var set = new HashSet<int>() { 1, 241, 33, 4, 531, 6, 7 };
            Console.WriteLine(String.Join(",", set));


            //Dictionary
            //zbior par
            var dict = new Dictionary<string, int>
            {
                {"Warszawa", 10000000 },
                {"Pruszkow", 1310000 },
                {"Grodzisk", 63265 },
                {"Cos", 532 }
            };
            foreach (var element in dict)
            {
                Console.WriteLine(element + ", ");
            }
            Console.WriteLine("-------------");
            dict["Ala"] = 412;
            dict["Warszawa"] = 412;
            Console.WriteLine(String.Join($",{Environment.NewLine}", dict));
            Console.WriteLine("-------------");
            Console.WriteLine(dict["Warszawa"]);

            //rzuca wyjatkiem
            // Console.WriteLine(dict["KluczKtoregoNieMa"]);

            if (dict.ContainsKey("KluczKtoregoNieMa"))
            {
                Console.WriteLine("operacja 1");
            }
            else
            {
                Console.WriteLine("operacja 2");
            }

        }
    }
}