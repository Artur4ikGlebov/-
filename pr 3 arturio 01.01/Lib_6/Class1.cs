using System;

namespace Lib_6
{
    public class CalculateModules
    {
        public int[] SumEven(int[,] matrix)
        {
            int sum = 0;
            int[] sums = new int[matrix.GetLength(0)];

            for (int i = 0; i < matrix.GetLength(0); i += 2)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    sum += matrix[i, j];
                }
                sums[i] += sum;
                sum = 0;
            }
            return sums;
        }
    }
}
