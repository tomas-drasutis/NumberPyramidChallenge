using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge
{
    class PathFinder
    {
        public int getMaxSum(int[,] pyramid, int N)
        {

            int[,] max_sum = new int[N, N];

            max_sum[0, 0] = pyramid[0, 0];

            for (int i = 1; i < N; i++)
            {
                for (int j = 0; j < i + 1 && j < N; j++)
                {
                    if (j == 0)
                    {
                        if (checkOddity(pyramid[i, 0]) != checkOddity(pyramid[i - 1, 0]) && max_sum[i - 1, 0] != 0) // First column elements have different bonds so have to be treated differently
                        {
                            max_sum[i, 0] = pyramid[i, 0] + max_sum[i - 1, 0];
                            continue;
                        }

                    }
                    else if ((checkOddity(pyramid[i, j]) != checkOddity(pyramid[i - 1, j - 1])))                    // Checking if the value matches the requirements with the value above
                    {
                        if (((max_sum[i - 1, j - 1] != 0)))
                        {
                            if (!(checkOddity(pyramid[i, j]) != checkOddity(pyramid[i - 1, j])) || max_sum[i - 1, j - 1] >= max_sum[i - 1, j])
                            {
                                max_sum[i, j] = pyramid[i, j] + max_sum[i - 1, j - 1];
                                continue;
                            }
                        }
                    }
                    if ((checkOddity(pyramid[i, j]) != checkOddity(pyramid[i - 1, j])))                             // Checking if the value matches the requirements with the other value
                    {
                        if (((max_sum[i - 1, j] != 0)))
                            max_sum[i, j] = pyramid[i, j] + max_sum[i - 1, j];
                    }
                }
            }

            int result = 0;

            for (int i = 0; i < N; i++)                                                                             // Finding the shortest path
            {
                if (result < max_sum[N - 1, i])
                {
                    result = max_sum[N - 1, i];
                }
            }

            return result;
        }

        /***********************************************************************************/
        public bool checkOddity(int num)
        {
            if (num % 2 == 0)
            {
                return false;
            }
            return true;
        }
    }
}
