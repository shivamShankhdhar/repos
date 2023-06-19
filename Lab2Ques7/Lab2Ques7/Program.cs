namespace Lab2Ques7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a character");
            int c = Console.Read();
            
            if(c >= 65 && c <= 90) {
                char newC = (char)(c + 32);
                Console.WriteLine("Upper Case {0} converted to lower case {1}",(char)c,newC);
            }
            else if(c >= 97 && c<= 122)
            {
                char newC = (char)(c - 32);
                Console.WriteLine("Lower Case {0} converted to Upper case {1}", (char)c,newC);
            }
           
        }
    }
}