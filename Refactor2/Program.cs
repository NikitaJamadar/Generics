using System;
using System.Collections.Generic;

namespace Refactor2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine($"Maximum integer number is {GenericClass<int>.FindMaxValue<int>(111, 666, 333)}");
            Console.WriteLine($"Maximum float number is {GenericClass<double>.FindMaxValue<double>(5.5, 4.4, 3.3)}");
            Console.WriteLine($"Maximum string is {GenericClass<string>.FindMaxValue<string>("Apple", "Banana", "Peach")}");
        }
       
    }
}
