namespace NLog_Assignment
{
    class program
    {
        static void Main(string[] args)
        {
            int a =0;
            int b = 1;
            Console.WriteLine("Addition Problem \n");
            AddNumber add = new AddNumber();
            Console.WriteLine("Result is " + " " + add.Sum(a, b));
            
        }
    }
}
