using System;
using System.Collections.Generic;

namespace TestTask
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[] { 4, 0, 3, 19, 492, -10, 1 };
            int result = Calc(arr);
            Console.WriteLine(result);
        }

        static int Calc(IEnumerable<int> arr)
        {
            int firstMin = int.MaxValue, secondMin = int.MaxValue;
            foreach(int e in arr)
            {
                if(e > secondMin) continue;
                if(e < firstMin)
                {
                    secondMin = firstMin;
                    firstMin = e;
                }
                else
                {
                    secondMin = e;
                }
            }
            return firstMin + secondMin;
        }
    }
}
