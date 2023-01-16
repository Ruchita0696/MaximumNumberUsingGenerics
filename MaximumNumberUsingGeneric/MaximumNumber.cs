using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumNumberUsingGeneric
{
    public class MaximumNumber
    {
        public static int MaximumIntegerNumber(int Number1, int Number2, int Number3)
        {
            if (Number1.CompareTo(Number2) > 0 && Number1.CompareTo(Number3) > 0 ||
                Number1.CompareTo(Number2) >= 0 && Number1.CompareTo(Number3) > 0 ||
                Number1.CompareTo(Number2) > 0 && Number1.CompareTo(Number3) >= 0)
            {
                return Number1;
            }
            if (Number2.CompareTo(Number1) > 0 && Number2.CompareTo(Number3) > 0 ||
                Number2.CompareTo(Number1) >= 0 && Number2.CompareTo(Number3) > 0 ||
                Number2.CompareTo(Number1) > 0 && Number2.CompareTo(Number3) >= 0)
            {
                return Number2;
            }
            if (Number3.CompareTo(Number1) > 0 && Number3.CompareTo(Number2) > 0 ||
                Number3.CompareTo(Number1) >= 0 && Number3.CompareTo(Number2) > 0 ||
                Number3.CompareTo(Number1) > 0 && Number3.CompareTo(Number2) >= 0)
            {
                return Number3;
            }
            return Number3;
        }
        public static float MaximumfloatNumber(float Number1, float Number2, float Number3)
        {
            if (Number1.CompareTo(Number2) > 0 && Number1.CompareTo(Number3) > 0 ||
                Number1.CompareTo(Number2) >= 0 && Number1.CompareTo(Number3) > 0 ||
                Number1.CompareTo(Number2) > 0 && Number1.CompareTo(Number3) >= 0)
            {
                return Number1;
            }
            if (Number2.CompareTo(Number1) > 0 && Number2.CompareTo(Number3) > 0 ||
                Number2.CompareTo(Number1) >= 0 && Number2.CompareTo(Number3) > 0 ||
                Number2.CompareTo(Number1) > 0 && Number2.CompareTo(Number3) >= 0)
            {
                return Number2;
            }
            if (Number3.CompareTo(Number1) > 0 && Number3.CompareTo(Number2) > 0 ||
                Number3.CompareTo(Number1) >= 0 && Number3.CompareTo(Number2) > 0 ||
                Number3.CompareTo(Number1) > 0 && Number3.CompareTo(Number2) >= 0)
            {
                return Number3;
            }
            return Number1;
        }
        public static string MaximumstringNumber(string String1, string String2, string String3)
        {
            if (String1.CompareTo(String2) > 0 && String1.CompareTo(String3) > 0 ||
                String1.CompareTo(String2) >= 0 && String1.CompareTo(String3) > 0 ||
                String1.CompareTo(String2) > 0 && String1.CompareTo(String3) >= 0)
            {
                return String1;
            }
            if (String2.CompareTo(String1) > 0 && String2.CompareTo(String3) > 0 ||
                String2.CompareTo(String1) >= 0 && String2.CompareTo(String3) > 0 ||
                String2.CompareTo(String1) > 0 && String2.CompareTo(String3) >= 0)
            {
                return String2;
            }
            if (String3.CompareTo(String1) > 0 && String3.CompareTo(String2) > 0 ||
                String3.CompareTo(String1) >= 0 && String3.CompareTo(String2) > 0 ||
                String3.CompareTo(String1) > 0 && String3.CompareTo(String2) >= 0)
            {
                return String3;
            }
            return String1;
        }

    }
}
