﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extractMatrixColumn
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        int[] extractMatrixColumn(int[][] matrix, int column)
        {
            int[] ret = new int[matrix.Length];
            for (int i = 0; i < matrix.Length; i++)
                ret[i] = matrix[i][column];
            return ret;
        }
    }
}
