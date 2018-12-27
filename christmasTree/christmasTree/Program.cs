using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace christmasTree
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        static string[] christmasTree(int levelNum, int levelHeight)
        {
            int ind = 0, L = 3 + levelNum * levelHeight + levelNum;
            string[] ret = new string[L];

            ret[ind++] = "*".PadLeft(levelNum + levelHeight + 1);
            ret[ind++] = "*".PadLeft(levelNum + levelHeight + 1);
            ret[ind++] = "***".PadLeft(levelNum + levelHeight + 2);

            for (int i = 0, j = 0; i < levelNum; i++, j += 2)
                for (int k = 0, l = 5 + j; k < levelHeight; k++, l += 2)
                    ret[ind++] = new string('*', l).PadLeft(l + levelNum + levelHeight - (k + 2) - i);

            int foot_W = levelHeight % 2 == 0 ? levelHeight + 1 : levelHeight;
            int max_W = 2 * (levelNum + levelHeight) + 1;

            for (int i = 0; i < levelNum; i++)
                ret[ind++] = new string('*', foot_W).PadLeft((foot_W + max_W) / 2);


            for (int i = 0; i < ret.Length; i++)
            {
                Console.WriteLine(ret[i]);
            }
            return ret;
        }
        /*
         * levelNum: 4
         * levelHeight: 8
         * 
         * 
        ["            *", 
         "            *", 
         "           ***", 
         "          *****", 
         "         *******", 
         "        *********", 
         "       ***********", 
         "      *************", 
         "     ***************", 
         "    *****************", 
         "   *******************", 
         "         *******", 
         "        *********", 
         "       ***********", 
         "      *************", 
         "     ***************", 
         "    *****************", 
         "   *******************", 
         "  *********************", 
         "        *********", 
         "       ***********", 
         "      *************", 
         "     ***************", 
         "    *****************", 
         "   *******************", 
         "  *********************", 
         " ***********************", 
         "       ***********", 
         "      *************", 
         "     ***************", 
         "    *****************", 
         "   *******************", 
         "  *********************", 
         " ***********************", 
         "*************************", 
         "        *********", 
         "        *********", 
         "        *********", 
         "        *********"]
         */
    }
}
