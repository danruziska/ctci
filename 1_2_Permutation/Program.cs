using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_2_Permutation
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "abc";
            string str2 = "cba";

            string str3 = "abc";
            string str4 = "adb";

            Console.WriteLine(isPermutation(str1,str2));
            Console.WriteLine(isPermutation(str3,str4));
        }

        public static bool isPermutation(string a, string b)
        {
            char[] charsA = a.ToCharArray();
            char[] charsB = b.ToCharArray();

            Array.Sort<char>(charsA);
            Array.Sort<char>(charsB);

            return new string(charsA) == new string(charsB);
        }
    }
}
