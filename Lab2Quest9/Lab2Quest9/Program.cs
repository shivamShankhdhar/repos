namespace Lab2Quest9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Temperature");
            int temp = Convert.ToInt32(Console.ReadLine());
            if(temp < 0) {
                Console.WriteLine("It's ICE");
            }
            else if (temp > 0 && temp < 100)
            {
                Console.WriteLine("It's WATER");
            }
            else if (temp > 100)
            {
                Console.WriteLine("It's Steam");
            }
        }
    }
}