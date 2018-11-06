using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace areIsomorphic
{
    class Program
    {
        static void Main(string[] args)
        {
            areIsomorphic(null, null);
        }

        static bool areIsomorphic(int[][] array1, int[][] array2)
        {

            if (array1 == null && array2 == null) return true;

            if (array1 == null && array2 != null) return false;

            if (array1 != null && array2 == null) return false;

            if (array1.Length !=  array2.Length) return false;

            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] == null && array2[i] == null)
                    continue;

                if (array1[i] == null && array2[i] != null) return false;
                if (array1[i] != null && array2[i] == null) return false;

                if (array1[i].Length != array2[i].Length) return false;
            }
            return true;

        }
    }
}
