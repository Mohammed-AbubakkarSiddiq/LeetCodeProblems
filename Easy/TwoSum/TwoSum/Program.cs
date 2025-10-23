using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 3, 3 };
            Solution solution = new Solution();
            var result = solution.TwoSum(nums, 6);
        }
    }

    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {

            int sum1 = 0, sum2 = 0;
            int[] result = new int[2] {0,0};
            bool sumFound = false;
            int index1 = 0, index2 = 0;

            for (index1 = 0; index1 <= nums.Length - 1; index1++)
            {
                sum1 = nums[index1];

                for (index2 = 0; index2 <= nums.Length - 1; index2++)
                {
                    sum2 = nums[index2];

                    sumFound = IsConditionSatisfy(index1, index2, sum1, sum2, target);

                    if (sumFound)
                    {
                        break;
                    }
                }

                if (sumFound)
                {
                    break;
                }
            }

            if (IsConditionSatisfy(index1, index2, sum1, sum2, target))
            {
                result[0] = index1;
                result[1] = index2;
            }

            return result;

        }

        public bool IsConditionSatisfy(int index1, int index2, int sum1, int sum2, int target)
        {
            if ((index1 != index2) && sum1 + sum2 == target)
            {
                return true;
            }
            return false;
        }
    }
}
