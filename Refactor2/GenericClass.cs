using System;
using System.Collections.Generic;
using System.Text;

namespace Refactor2
{
    class GenericClass<T>
    {
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
