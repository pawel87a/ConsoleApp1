namespace ConsoleApp1;
public class Program
{

    public static int Suma(int[] t)
    {
        int suma = 0;
        for (int i = 0; i < t.Length; i++)
        {
            suma += t[i];
        }
        return suma;
    }


    public static void Main(string[] args)
    {
        // See https://aka.ms/new-console-template for more information
        Console.WriteLine("Hello, World!");
        // cw + 2xtab
        // ctrl + k,d autoformatowanie
        // ctr + k,c to zakomentowanie zaznacznia
        //ctrl+ k,u odkowmentowanie zaznaczenia
        //alt + strzalka linijka w gore w dol

        int x = 10;
        int x1 = 23, x2, x3 = 42;
        var x4 = true; // var sam wykrywa typ na podstawie przypisania
        var x5 = 320532532532532;

        //wypisz stan zmiennej x5
        Console.WriteLine("x5 = " + x5);
        Console.WriteLine($"x5 = {x5} dalszy ciag");
        Console.WriteLine(
            $@"Dzis \t
jest 
ladna 
pogoda.{x5}");

        x1 = 10;
        x2 = 5;
        Console.WriteLine(x1 + x2 + "wrt");// 15wrt
        Console.WriteLine("wrt" + x1 + x2);//wrt105
        Console.WriteLine("wrt" + (x1 + x2));//wrt15

        if (x1 > 1)
        {
            Console.WriteLine(1);
        }
        else if (x2 < 3)
        {
            Console.WriteLine(2);
        }
        else
        {
            Console.WriteLine(3);
        }

        int i = 0;
        while (i < 10)
        {
            Console.WriteLine(i);
            i++;
        }

        i = 20;
        do
        {
            Console.WriteLine("do while");
        } while (i < 10);

        //deklaracje i inicjalizacje tablic
        int[] t1 = new int[10];
        int[] t2 = { 4, 2, 65, 6, 8, 34, 4 };
        int[] t3;
        //kod pomiedzy a potem inicjalizacja
        t3 = new int[] { 4, 3, 3, 2, 2, 3, 3, 3, };

        var suma = Suma(t2);
        Console.WriteLine(suma);

        //for(int element: t2)
        //{
        //    System.out.print(element + ", ")
        //}
        //System.out.println();

        foreach(var element in t2)
        {
            Console.Write(element + ", " );
        }
        Console.WriteLine();
        var s = "Ala ma kota";
        Console.ReadKey();
       
    }
}


