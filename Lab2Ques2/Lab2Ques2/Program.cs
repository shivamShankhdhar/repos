namespace Lab2Ques2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");
            int f_num = Convert.ToInt32(Console.ReadLine()); //getting first number
            Console.WriteLine("Enter Second number");
            int s_num = Convert.ToInt32(Console.ReadLine()); //getting second number
            Console.WriteLine("Enter third number");
            int t_num = Convert.ToInt32(Console.ReadLine()); //getting third number
             
            int greater = f_num > s_num ?(f_num>t_num? f_num:t_num) : (s_num>t_num?s_num:t_num);
            Console.WriteLine("In numbers  {0}, {1} and {2} number {3} is greater", f_num,s_num,t_num,greater);
        }
    }
}