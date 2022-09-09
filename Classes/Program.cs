using Classes.Models;

namespace Classes;

public class Program
{

    public static void Main(string[] args)
    {


        Person p = new Person("Andrzej", 16);

        //p.age =  1000214;
        p.SetAge(20);

        Console.WriteLine(p.GetAge());
        // See https://aka.ms/new-console-template for more information
        Console.WriteLine("Hello, World!");
    }
}