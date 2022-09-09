using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrukturyDanychZadania
{
    internal class Delegaty
    {


        //metoda ktora ma dwa parametry typu int(dowolnej nazwy) i zwraca inta jest typu Operation
        public delegate int Operation(int a, int b);

        public static int Suma(int x1, int x2)
        {
            return x1 + x2;
        }

        public static void M()
        {
            Operation o = Suma;
            Console.WriteLine(o(1, 2));
        }
    }
}
