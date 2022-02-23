using System;

namespace UC4
{
    class Program
    {
        static void Main(string[] args)
        {
			
			MaxCount<int> intValue = new MaxCount<int>(27, 52, 48, 73, 36);
			intValue.MaxValue();

            MaxCount<float> floatValue = new MaxCount<float>(64.2f, 28.3f, 83.3f, 73.4f, 93.3f);
            floatValue.MaxValue();

            MaxCount<string> stringValue = new MaxCount<string>("N", "K", "S", "R", "J");
            stringValue.MaxValue();
        }
    }
}
