using System;
using System.Collections.Generic;

namespace HackerRank_PlusMinus
{
    class Program
    {
        static void Main(string[] args)
        {
            plusMinus(new List<int>(){-4, 3, -9, 0, 4, 1});
        }

        public static void plusMinus(List<int> arr)
        {
            double counterNegative = 0;
            double counterPozitive = 0;
            double counterZero= 0;

            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i] < 0)
                {
                    counterNegative++;
                }
                else if (arr[i] > 0)
                {
                    counterPozitive++;
                }
                else if (arr[i] == 0)
                {
                    counterZero++;
                }
            }

            Console.WriteLine((counterPozitive / arr.Count).ToString("0.00000") );
            Console.WriteLine((counterNegative / arr.Count).ToString("0.00000"));
            Console.WriteLine((counterZero / arr.Count).ToString("0.00000"));
        }
    }
}
