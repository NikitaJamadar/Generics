using System;

namespace UC2
{
    class Program
    {
        static void Main(string[] args)
        {
            double maxNumber = Program.FindmaxFloatnumber(1.6, 1.9, 1.4);
            Console.WriteLine("Maximum number is :" + maxNumber);
        }
        public static double FindmaxFloatnumber(double num1, double num2, double num3)
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
