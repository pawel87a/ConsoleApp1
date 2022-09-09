using Classes.Models;
using ClassesCSharpStyle;

namespace Classes;

public class Program
{

    public static void Main(string[] args)
    {


        Person p = new Person("Andrzej", 16);

        //p.age =  1000214;
        //LHS = RHS
        p.Age = 20;
        p.Name = "Alfons";
        Console.WriteLine(p.Age);
        // See https://aka.ms/new-console-template for more information

        //var -> sam sie domysl typu
        var product = new Product();
        product.Price = 3;
        Console.WriteLine(product.PriceWTax);
        var product2 = new Product() {
            Price = 1 
        };
        var person = new Person()
        {
            Age = 20,
            Name = "Bogdan"
        };

        product.PriceWTax = 2.20;


        Console.WriteLine("Hello, World!");
    }
}