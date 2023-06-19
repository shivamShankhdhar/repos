namespace Ques9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            Console.WriteLine("value of a = {0} and b = {1}", a, b);
            int c = a;
            a = b;
            b = c;
            Console.WriteLine("value after exchange of a = {0} and b = {1}", a, b);
        }
    }
}