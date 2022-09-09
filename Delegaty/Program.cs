namespace Delegaty
{
    internal class Program
    {

        //metoda ktora ma dwa parametry typu int(dowolnej nazwy) i zwraca inta jest typu Operation
        public delegate int Operation(int a, int b);

        public static int Add(int x1, int x2) => x1 + x2;

        public static int Subtract(int x1, int x2) => x1 - x2;

        public static int Multiply(int x1, int x2) => x1 * x2;


        public static int ExecuteOperation(Operation o, int a, int b) => o(a, b);


        static void Main(string[] args)
        {
            Operation o = Add;
            Console.WriteLine(o(1, 2));

            Console.WriteLine(ExecuteOperation(Multiply, 10, 5));


            Operation lambdaExpression = (int a, int b) =>
            {
                Console.WriteLine("zrob cos jeszcze bo jestes w klamrze");
                return a / b;
            };
            lambdaExpression = (a, b) =>
            {
                Console.WriteLine("zrob cos jeszcze bo jestes w klamrze");
                return a / b;
            };

            lambdaExpression = (dowolnaNazwa1, dowolnaNazwa2) => dowolnaNazwa1 / dowolnaNazwa2;

            Comparison<int> comp = (a, b) => a - b;


        }
    }
}