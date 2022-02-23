using System;
using System.Collections.Generic;
using System.Text;

namespace UC5
{
    class MaxCount<T>
    {
        
        public T[] Values;
       
        public MaxCount(params T[] Values)
        {
            this.Values = Values;
        }
      
        public T[] SortValues(T[] Values)
        {
            Array.Sort(Values);
            return Values;
        }
       
        public T TestMaximum(T[] values)
        {
            var maxValue = SortValues(Values);
            return maxValue[maxValue.Length-1];
        }
        public void PrintMax()
        {
            Console.WriteLine("max value:" + TestMaximum(Values));
        }
       
    }
}

