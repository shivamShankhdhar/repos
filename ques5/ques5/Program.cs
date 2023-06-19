namespace ques5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter length of triangle");
            float length = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter width of triangle");
            float width = float.Parse(Console.ReadLine());
            float area = (length * width)/2;
            Console.WriteLine("Area of triangle is {0}", area);
        }
    }
}