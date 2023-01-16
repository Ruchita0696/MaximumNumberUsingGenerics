namespace MaximumNumberUsingGeneric
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MaximumNumber maximum = new MaximumNumber();

            Console.WriteLine("Maximum Interger Number is : " + MaximumNumber.MaxNumber(30, 20, 10));
            Console.WriteLine("Maximum Float Number is : " + MaximumNumber.MaxNumber<float>(30, 20, 10));
            Console.WriteLine("Maximum String Number is : " + MaximumNumber.MaxNumber("44", "30", "10"));
        }

    }
}