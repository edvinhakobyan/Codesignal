using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverseOnDiagonals
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        static int[][] reverseOnDiagonals(int[][] matrix)
        {
            for (int i = 0, j = matrix.Length - 1; i < matrix.Length; i++,j--)
            {
                matrix[i][i] ^= matrix[j][j];
                matrix[j][j] ^= matrix[i][i];
                matrix[i][i] ^= matrix[j][j];

                matrix[i][j] ^= matrix[j][i];
                matrix[j][i] ^= matrix[i][j];
                matrix[i][j] ^= matrix[j][i];
            }
            return matrix;
        }
       


    }
}
