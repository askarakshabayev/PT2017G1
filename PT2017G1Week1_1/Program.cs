using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PT2017G1Week1_1
{
    class Program
    {
        static bool isEven(int a)
        {
            if (a % 2 == 0)
                return true;
            return false;
        }

        static void Main(string[] args)
        {
            int n = args.Length;
            for (int i = 0; i < n; i++)
            {
                string s = args[i]; // "5"
                int p = int.Parse(s); // p = 5

                if (isEven(p) == false) {
                    Console.WriteLine(p);
                }
            }
        }
    }
}
