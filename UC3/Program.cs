using System;

namespace UC3
{
    class Program
    {
        static void Main(string[] args)
        {
            string maxstring = Program.FindmaxString("Apple", "Peach", "Banana");
            Console.WriteLine("Maximum string is :" + maxstring);
        }
        public static string FindmaxString(string string1, string string2, string string3)
        {
            if (string1.CompareTo(string2) > 0 && string1.CompareTo(string3) > 0)
            {
                return string1;
            }
            else if (string2.CompareTo(string3) > 0 && string2.CompareTo(string1) > 0)
            {
                return string2;
            }
            else
            {
                return string3;
            }
        }
    }
}
