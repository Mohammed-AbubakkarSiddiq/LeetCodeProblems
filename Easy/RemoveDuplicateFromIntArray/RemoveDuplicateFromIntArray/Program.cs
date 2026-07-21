using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveDuplicateFromIntArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            var result = RemoveDuplicates(nums);
        }

        public static int RemoveDuplicates(int[] nums)
        {
            int previousNum = 0;
            List<int> temp = new List<int>(nums);
            for (int i = 0; i < nums.Length; i++)
            {
                int currentNum = nums[i];

                if (i > 0)
                {
                    previousNum = nums[i - 1];   
                }

                if (currentNum == previousNum && i>0)
                {
                    temp.Remove(currentNum);
                }
            }

            for (int i = 0; i < temp.Count; i++)

            {
                nums[i] = temp[i];
            }

            return temp.Count;
        }
    }
}
