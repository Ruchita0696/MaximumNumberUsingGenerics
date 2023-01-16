using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumNumberUsingGeneric
{
    public class MaximumNumberUsingMaxMethod<M> where M : IComparable
    {
        public M[] value;
        public MaximumNumberUsingMaxMethod(M[] value)
        {
            this.value = value;
        }
        public M[] Sort(M[] values)
        {
            Array.Sort(values);
            return values;
        }
        public M MaxValue(params M[] values)
        {
            var sorted_values = Sort(values);
            return sorted_values[^1];
        }
        public M MaxMethod()
        {
            var Max = MaxValue(this.value);
            return Max;
        }
        public void PrintMaxValue()
        {
            var Max = MaxValue(this.value);
            Console.WriteLine("Maximum Value is : " + Max);
        }
    }
}
