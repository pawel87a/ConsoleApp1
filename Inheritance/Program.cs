using Inheritance;

namespace Classes;
public class Program
{
    public static void Main(string[] args)
    {
        var student = new Student()
        {
            FirstName = "Marcin",
            IndexId = "2"
        };
        //wywolaj metode Print na rzecz studenta
        student.Print();

        var student2 = new Student("Andrzej", "3");

        Console.WriteLine(student2);

        Console.WriteLine("Hello, World!");
        Console.WriteLine(student is Person);

        Person person = new Student("Anna", "4");
        Object o = new object();
        //person.index
        Student s1 = person as Student;
        Console.WriteLine(s1.IndexId);
        Student s2 = (Student)person;



        //File.WriteAllLines("parts.csv", parts.Select(x => x.ToString()));
    }

    class Part
    {
        public string Number { get; set; }
        public double Price { get; set; }
        public string DiscountGroup { get; set; }
        public DateTime PriceStartDate { get; set; }

        public override string ToString()
        {
            return $"{Number},{Price},{DiscountGroup}";
        }
    }
}
