namespace Ques3
{
    internal class Program
    {
        static void Main(string[] args)
        {
     
            Console.WriteLine("Enter first number");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second number");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Choose what operation you wants");
            Console.WriteLine("1 ----> ADD");
            Console.WriteLine("2 ----> SUB");
            Console.WriteLine("3 ----> MUL");
            Console.WriteLine("4 ----> DIV");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1: 
                    int sum  = x + y;
                    Console.WriteLine("Sum is {0}", sum);
                    break;
                case 2:
                    int sub =x - y;
                    Console.WriteLine("sUBSTRACTION IS {0}", sub);
                    break;
                case 3:
                    int mul = x * y;
                    Console.WriteLine("Multiplication is {0}", mul);
                    break;
                case 4:
                    int div = x / y;
                    Console.WriteLine("Division is {0}", div);
                    break;
                default:Console.WriteLine("Wrong choice of operation");
                    break;

            }
            
        }
    }
}

//3.Write a single program to perform all arithmetic operations. Numbers should be entered
//by the user
//Addition
//Subtraction
//Multiplication
//Division
