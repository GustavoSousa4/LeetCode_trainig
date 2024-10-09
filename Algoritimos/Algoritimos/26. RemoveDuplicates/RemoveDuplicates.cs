using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritimos
{
    internal class RemoveDuplicates
    {
        public int removeDuplicates(int[] nums)
        {
            int count = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] != nums[count - 1])
                {
                    nums[count] = nums[i];
                    count++;
                }
            }
            return count;
        }

        public int removeDuplicatesLinq(int[] nums)
        {
            if(nums == null || nums.Length == 0) return 0;

            var target = nums.Distinct().ToArray();
            Array.Copy(target, nums, target.Length);

            return target.Length;
        }
    }
}
