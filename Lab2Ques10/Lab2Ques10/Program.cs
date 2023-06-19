namespace Lab2Ques10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Percentage");
            double percentage = double.Parse(Console.ReadLine());
            if(percentage >= 60)
            {
                Console.WriteLine("First Division");
            }else if (percentage >= 50 && percentage <= 59)
            {
                Console.WriteLine("Second Division");
            }
            else if (percentage >= 40 && percentage <= 49)
            {
                Console.WriteLine("Third Division");
            }
            else if (percentage < 40)
            {
                Console.WriteLine("Oh dear! you are fail");
            }
        }
    }
}