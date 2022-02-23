using System;

namespace UC1
{
    class Program
    {
        static void Main(string[] args)
        {
           int maxNumber= Program.FindmaxIntnumber(10, 40, 20);
            Console.WriteLine("Maximum number is :"+maxNumber);
        }
        public static int FindmaxIntnumber(int num1, int num2, int num3)
        {
            if (num1.CompareTo(num2) > 0 && num1.CompareTo(num3) > 0)
            {
                return num1;
            }
            else if (num2.CompareTo(num3) > 0 && num2.CompareTo(num1) > 0)
            {
                return num2;
            }
            else
            {
                return num3;
            }
        }
    }
}
