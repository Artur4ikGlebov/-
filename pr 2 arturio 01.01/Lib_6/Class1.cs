using System;

namespace Lib_6
{
    public class CalculateActs
    {
        public int Calc(int[] array)
        {
            int sumLessThan15 = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 15)
                {
                    sumLessThan15 += array[i];
                }
            }
            return sumLessThan15;
        }
    }
}
