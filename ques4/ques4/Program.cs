namespace ques4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter third number");
            int z = Convert.ToInt32(Console.ReadLine());
            int avg = (x + y + z)/3;
            Console.WriteLine("Average is {0}", avg);
        }
    }
}