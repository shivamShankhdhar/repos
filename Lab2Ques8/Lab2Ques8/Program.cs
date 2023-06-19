namespace Lab2Ques8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Pin");
            int pin = Convert.ToInt32(Console.ReadLine());
            if(pin == 1234)  
            {
                Console.WriteLine("You can Withdraw money from ATM");
            }
            else
            {
                Console.WriteLine("You can not Withdraw money from ATM");
            }
        }
    }
}