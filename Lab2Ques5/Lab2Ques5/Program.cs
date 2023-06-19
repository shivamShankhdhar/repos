namespace Lab2Ques5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a year");
            int year = Convert.ToInt32(Console.ReadLine());
            if(year % 100 == 0)
            {
                if(year % 400 == 0) {
                    Console.WriteLine("Year {0} is Leap Year",year);
                }
                else
                {
                    Console.WriteLine("Year {0} is not Leap Year",year);
                }
            }
            else {
                if (year % 4 == 0)
                {
                    Console.WriteLine("Year {0} is Leap Year", year);
                }
                else
                {
                    Console.WriteLine("Year {0} is not Leap Year", year);
                }
            }
        }
    }
}