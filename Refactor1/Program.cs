using System;
using System.Collections.Generic;

namespace Refactor1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine($"Maximum integer number is {Program.FindMaxValue<int>(111,666,333)}");
            Console.WriteLine($"Maximum float number is {Program.FindMaxValue<double>(5.5, 4.4, 3.3)}");
            Console.WriteLine($"Maximum string is {Program.FindMaxValue<string>("Apple","Banana","Peach")}");
        }
        public static T FindMaxValue<T>(T FirstValue, T secondValue, T thirdValue)
        {
            if (Comparer<T>.Default.Compare(FirstValue, secondValue) > 0 && Comparer<T>.Default.Compare(FirstValue, thirdValue) > 0)
            {
                return FirstValue;
            }
            else if (Comparer<T>.Default.Compare(secondValue, FirstValue) > 0 && Comparer<T>.Default.Compare(secondValue, thirdValue) > 0)
            {
                return secondValue;
            }
            else
            {
                return thirdValue;
            }
        }
    }
}
