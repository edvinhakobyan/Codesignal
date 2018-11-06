using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drawRectangle
{
    class Program
    {
        static void Main(string[] args)
        {



        }
        char[][] drawRectangle(char[][] can, int[] r)
        {
            int i0 = r[1], j0 = r[0], i1 = r[3], j1 = r[2];
            can[i0][j0] = can[i0][j1] = can[i1][j0] = can[i1][j1] = '*';

            for (int i = i0 + 1; i < i1; i++)
                can[i][j0] = can[i][j1] =  '|';
            for (int j = j0 + 1; j < j1; j++)
                can[i0][j] = can[i1][j] = '-';
            return can;
        }

/*
canvas: 
[["a","a","a","a","a","a","a","a"], 
 ["a","a","a","a","a","a","a","a"], 
 ["a","a","a","a","a","a","a","a"], 
 ["b","b","b","b","b","b","b","b"]]
rectangle: [0, 2, 7, 3]
Expected Output:
[["a","a","a","a","a","a","a","a"], 
 ["a","a","a","a","a","a","a","a"], 
 ["*","-","-","-","-","-","-","*"], 
 ["*","-","-","-","-","-","-","*"]]
*/
    }
}
