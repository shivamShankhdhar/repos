namespace ques7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter principle amount ");
            double principle = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter rate of interest");
            double rate = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter time in years");
            double time= double.Parse(Console.ReadLine());
            
            double amount = (principle*rate*time)/100 + principle;
            Console.WriteLine("Simple interest {0}", amount);
        }
    }
}