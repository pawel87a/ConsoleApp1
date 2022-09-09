namespace ConsoleApp3;

public class Program
{
    public static void Main(string[] args)
    {
        var account1 = new Account()
        {
            Balance = 100
        };
        var account2 = new Account(500);
        Console.WriteLine(account1);
        Console.WriteLine(account2);
        Console.WriteLine(Account.Transfer(account1, account2, 600));
        Console.WriteLine(Account.Transfer(account1, account2, 50));
        Console.WriteLine(account1);
        Console.WriteLine(account2);
        try
        {
            Account.Transfer(account1, account2, -100);
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex);
        }
    }

}