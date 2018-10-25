using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fileNaming
{
    class Program
    {
        static void Main(string[] args)
        {
            fileNaming(new string[]{ "doc", "doc", "image", "doc(1)", "doc"});
        }

        static string[] fileNaming(string[] names)
        {
            for (int i = 0; i < names.Length - 1; i++)
            {
                int next = 0;
                for (int j = i + 1; j < names.Length; j++)
                {
                    if (names[i] == names[j])
                    {
                        while (IfContainsWhileIndex(names, $"{names[j]}({++next})", j-1)) { }
                        names[j] = $"{names[j]}({next})";
                    }
                        
                }
            }
            return names;

            /*["doc", "doc(1)", "image", "doc(1)(1)", "doc(2)"]*/
        }

        static bool IfContainsWhileIndex(string[] a, string b, int ind)
        {
            for (int i = 0; i < ind; i++)
                if (a[i] == b)
                    return true;
            return false;
        }



    }
}
