using System;
using System.Linq;
using System.Collections.Generic;

namespace Transform
{
    public delegate int operation(int n);
    public static class Transform
    {
        public static int[] Map(this int[] numbers, operation Operate)
        {
            for (int i = 0; i < numbers.Count(); i++)
            {
                numbers[i] = Operate(numbers[i]);
            }
            return numbers;
        }
    }
}
