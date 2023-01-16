using static MaximumNumberUsingGeneric.MaximumNumber;

namespace MaximumNumberUsingGeneric
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MaximumNumber<int> maximumInt = new MaximumNumber<int>(30, 20, 10);
            Console.WriteLine("Maximum Number is : " + maximumInt.MaxMethod());
            MaximumNumber<float> maximumFloat = new MaximumNumber<float>(10, 20, 30);
            Console.WriteLine("Maximum Number is : " + maximumFloat.MaxMethod());
            MaximumNumber<string> maximumString = new MaximumNumber<string>("20", "30", "10");
            Console.WriteLine("Maximum Number is : " + maximumString.MaxMethod());
        }

    }
}