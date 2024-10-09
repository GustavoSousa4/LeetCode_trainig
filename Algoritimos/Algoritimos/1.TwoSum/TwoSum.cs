using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritimos._1.TwoSum
{
    public class TwoSum
    {
        public int[] twoSum(int[] nums, int target)
        {

            int[] sum = new int[2];
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                    if (nums[i] + nums[j] == target)
                    {
                        sum[0] = i;
                        sum[1] = j;
                        break;
                    }
            }
            return sum;
        }
    }
}
