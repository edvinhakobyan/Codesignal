using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crossingSum
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        int crossingSum(int[][] matrix, int a, int b)
        {
            int sum = 0;
            for (int i = 0; i < matrix.Length; i++)
                sum += matrix[i][b];
            for (int i = 0; i < matrix[0].Length; i++)
                if (i != b)
                    sum += matrix[a][i];
            return sum;
        }
    }
}
