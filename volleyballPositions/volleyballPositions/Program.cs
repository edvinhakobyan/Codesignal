using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace volleyballPositions
{
    class Program
    {
        static void Main(string[] args)
        {

            volleyballPositions(new string[][] {
 new string[]{"empty", "Player5", "empty" },
 new string[]{"Player4", "empty", "Player2" },
 new string[]{"empty", "Player3", "empty" },
 new string[]{"Player6", "empty", "Player1" } },2);
        }

        static string[][] volleyballPositions(string[][] formation, int k)
        {
            for (int i = 0; i < k%6; i++)
                Rotate(formation);
            return formation;
        }

        static public void Rotate(string[][] f)
        {
            string[] t = { f[0][1], f[1][0], f[3][0], f[2][1], f[3][2], f[1][2] };
            f[1][0] = t[0];
            f[3][0] = t[1];
            f[2][1] = t[2];
            f[3][2] = t[3];
            f[1][2] = t[4];
            f[0][1] = t[5];
        }
             //[["empty",   "Player5", "empty"],
             //["Player4", "empty",   "Player2"],
             //["empty",   "Player3", "empty"],
             //["Player6", "empty",   "Player1"]]


    }
}
