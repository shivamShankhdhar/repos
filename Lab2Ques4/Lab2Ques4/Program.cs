namespace Lab2Ques4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age");
            int age = Convert.ToInt32(Console.ReadLine());
            if(age > 18)
            {
                Console.WriteLine("Eligible for vote");
            }
            else { 
                Console.WriteLine("Not Eligible for vote");
            }
        }
    }
}