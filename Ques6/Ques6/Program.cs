namespace Ques6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter temperature in celcius");
            double c = double.Parse(Console.ReadLine());
            double F = c * 9/ 5 + 32;
            Console.WriteLine("Temperature in farenehite {0} for {1} Celcius", F, c);
        }
    }
}