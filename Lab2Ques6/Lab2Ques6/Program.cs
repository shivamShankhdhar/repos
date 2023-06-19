namespace Lab2Ques6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a character");
            char c = Convert.ToChar(Console.ReadLine());
           
            if(c == 'A' || c == 'a') {
                Console.WriteLine("The Character {0} is a vowel",c);
            }
            else if (c == 'E' || c == 'e')
            {
                Console.WriteLine("The Character {0} is a vowel", c);
            }
            else if (c == 'I' || c == 'i')
            {
                Console.WriteLine("The Character {0} is a vowel", c);
            }
            else if (c == 'O' || c == 'o')
            {
                Console.WriteLine("The Character {0} is a vowel", c);
            }
            else if (c == 'U' || c == 'u')
            {
                Console.WriteLine("The Character {0} is a vowel", c);
            }
            else
            {
                Console.WriteLine("The Character {0} is not a vowel", c);
            }
        }
    }
}