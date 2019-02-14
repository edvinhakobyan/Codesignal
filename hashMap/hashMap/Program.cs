using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hashMap
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        long hashMap(string[] queryType, int[][] query)
        {
            List<int[]> list = new List<int[]>(10000);
            long ret = 0;
            for (int i = 0; i < queryType.Length; i++)
            {
                switch (queryType[i])
                {
                    case "insert": list.Add(query[i]); break;
                    case "addToValue":
                        for (int j = 0; j < list.Count; j++)
                            list[j][1] += query[i][0]; break;

                    case "addToKey":
                        for (int j = 0; j < list.Count; j++)
                            list[j][0] += query[i][0]; break;
                    case "get":
                        for (int j = 0; j < list.Count; j++)
                            if (list[j][0] == query[i][0])
                                ret += list[j][1]; break;
                }
            }
            return ret;
        }
    }
}
