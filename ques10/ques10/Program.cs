namespace ques10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter employee name");
            string name     = Console.ReadLine();   

            Console.WriteLine("enter age");
            int age         = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ENTER PHONE NUMBER");
            double number      = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter email");
            string email    = Console.ReadLine();

            Console.WriteLine("enter address");
            string address  = Console.ReadLine();
            Console.WriteLine("------------- Details -----------");

            string empDetails = "Employee name: " + name + "\nAge: " + age + "\nNumber: " 
                + number + "\nemail" + email + "\nAddress: " + address;
            Console.WriteLine(empDetails);

        }
    }
}