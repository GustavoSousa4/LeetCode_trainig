using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritimos
{
    internal class RemoveElement
    {
        public int removeElement(int[] nums, int val)
        {
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[count] = nums[i];
                    count++;
                }
            }
            return count;
        }
        public int removeElementLinq(int[] nums, int val)
        {
            if(nums is null || nums.Length == 0) return 0;
            
            var target = nums.Where(x => x != val).ToArray();
            Array.Copy(target, nums, target.Length);
            
            return target.Length;
        }
    }
}
