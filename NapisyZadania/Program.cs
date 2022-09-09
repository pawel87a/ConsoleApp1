namespace NapisyZadania;
public class Program
{


    //public static string SumaNapisow(string.. napisy)
    //{

    //}

    public static string SumaNapisow(params string[] napisy)
    {
        string suma = string.Empty;
        for (int i = 0; i < napisy.Length; i++)
        {
            suma += napisy[i];
        }
        return suma;
    }

    public static void M(int[] a, int xyz)
    {
        xyz++;
        a[0]++;
        Console.WriteLine($"{xyz} {a[0]}");//1 1
    }

    public static void PrzedstawSie(string imie, bool podajWiek = false) //parametr opcjonalny z domyslna wartoscia
    {
        Console.WriteLine($"Czesc jeste {imie}");
        Console.WriteLine(podajWiek ? "Mam iles lat" : "Nie powiem ile mam lat");
    }

    public static void Main(string[] args)
    {
        string s = "Ladna pogoda dzis.";
        Console.WriteLine(s[2]);
        Console.WriteLine(s.Length);
        Console.WriteLine(s.ToLower());
        var result = SumaNapisow("napis ", "inny ", "jeszcze inny");
        Console.WriteLine(result);
        var x = 0;
        int[] t = { 0 };
        Console.WriteLine($"{x} {t[0]}");//0 0
        M(t, x);
        Console.WriteLine($"{x} {t[0]}");//0 1
        int[] t1 = t;
        t1[0]++;
        Console.WriteLine(t[0]);
        PrzedstawSie("Roman", true);
        PrzedstawSie("Roman");
    }
}


