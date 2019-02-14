using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alternatingSort
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        static bool alternatingSort(int[] a)
        {
            int[] b = new int[a.Length];

            int ind = 0;
            for (int i = 0, j = a.Length - 1; i < j; i++, j--)
            {
                b[ind++] = a[i];
                b[ind++] = a[j];
            }

            if (a.Length % 2 == 1)
                b[b.Length - 1] = a[b.Length / 2];

            for (int i = 1; i < b.Length; i++)
                if (b[i - 1] >= b[i])
                    return false;
            return true;
        }
    }
}
