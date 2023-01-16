namespace MaximumNumberUsingGeneric
{
    public class Program
    {
        static void Main(string[] args)
        {
            MaximumNumber maximum = new MaximumNumber();

            Console.WriteLine("Maximum Interger Number is : " + maximum.MaxNumber<int>(30, 20, 10));
            Console.WriteLine("Maximum Float Number is : " + maximum.MaxNumber<float>(30, 20, 10));
            Console.WriteLine("Maximum String Number is : " + maximum.MaxNumber<string>("44", "30", "10"));
        }
    }
}