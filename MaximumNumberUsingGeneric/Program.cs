using static MaximumNumberUsingGeneric.MaximumNumber;

namespace MaximumNumberUsingGeneric
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Maximum Number is : " + MaximumNumber.MaximumIntegerNumber(20, 10, 30));
            Console.WriteLine("Maximum Number is : " + MaximumNumber.MaximumfloatNumber(20.10f, 10.50f, 30.68f));
        }

    }
}