namespace ques8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            double num = double.Parse(Console.ReadLine());
            Console.WriteLine("Square of {0} is {1}", num, num * num);
        }
    }
}