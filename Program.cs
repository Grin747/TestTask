using System;
using System.Collections.Generic;

namespace TestTask
{
    public class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[] { 4, 0, 3, 19, 492, -10, 1 };
            int result = Calc(arr);
            Console.WriteLine(result);
        }

        public static int Calc(IEnumerable<int> arr)
        {
            int firstMin = int.MaxValue, secondMin = int.MaxValue;
            foreach(int e in arr)
            {
                Console.WriteLine(e);
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

            if (secondMin == int.MaxValue)
                throw new InvalidOperationException();

            return firstMin + secondMin;
        }
    }
}
