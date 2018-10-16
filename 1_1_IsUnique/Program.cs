using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_1_IsUnique
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "1s2#A!";
            string str2 = "!s1B!";
            string str3 = "aAbc?";
            string str4 = "aA!sA#";


            Console.WriteLine("IsUnique1");
            Console.WriteLine(IsUnique1(str1));
            Console.WriteLine(IsUnique1(str2));
            Console.WriteLine(IsUnique1(str3));
            Console.WriteLine(IsUnique1(str4));

            Console.WriteLine("IsUnique2");
            Console.WriteLine(IsUnique2(str1));
            Console.WriteLine(IsUnique2(str2));
            Console.WriteLine(IsUnique2(str3));
            Console.WriteLine(IsUnique2(str4));
        }

        //Usando estrutura de dados
        //Tempo de criação: 05:03:568
        public static bool IsUnique1(string str)
        {
            Dictionary<char, bool> characters = new Dictionary<char, bool>();

            foreach (var character in str)
            {
                if (characters.ContainsKey(character))
                    return false;
                characters.Add(character, true);
            }

            return true;
        }

        //Sem usar estrutura de dados
        //Tempo de criação: 15:45:074
        public static bool IsUnique2(string str)
        {
            char[] chars = str.ToCharArray();
            Array.Sort<char>(chars);

            for (int i = 0; i < chars.Length - 1; i++)
            {
                if (chars[i] == chars[i + 1])
                    return false;
            }

            return true;
        }
    }
}
