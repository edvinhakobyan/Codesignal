using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swapDiagonals
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        int[][] swapDiagonals(int[][] matrix)
        {
            for (int i = 0, j = matrix.Length - 1; i < matrix.Length; i++, j--)
            {
                if (i != j)
                {
                    matrix[i][i] ^= matrix[i][j];
                    matrix[i][j] ^= matrix[i][i];
                    matrix[i][i] ^= matrix[i][j];
                }
            }
            return matrix;
        }
    }
}
