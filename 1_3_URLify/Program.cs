﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URLify
{
    class Program
    {
        static void Main(string[] args)
        {
            string teste = "Dan Ruziska  ";
            Console.WriteLine(URLify(teste,11));
        }

        static string URLify(string str1, int trueLength)
        {
            char[] str = str1.ToCharArray();
            int spaceCount = 0, index, i = 0;
            for (i = 0; i < trueLength; i++)
            {
                if (str[i] == ' ')
                {
                    spaceCount++;
                }
            }
            index = trueLength + spaceCount * 2;
            if (trueLength < str.Length) str[trueLength] = '\0';
            for (i = trueLength - 1; i >=0; i--)
            {
                if (str[i] == ' ')
                {
                    str[index - 1] = '0';
                    str[index - 2] = '2';
                    str[index - 3] = '%';
                    index = index - 3;
                }
                else
                {
                    str[index - 1] = str[i];
                    index--;
                }
            }

            return new string(str);
        }
    }
}
