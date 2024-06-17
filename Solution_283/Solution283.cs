using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solution_283
{
    public class Solution283
    {
        public void Main()
        {
            int[] result = MoveZero(new int[] { 0, 1, 0, 3, 12 });

            foreach(int i in result)
            {
                Console.WriteLine(i);
            }

            result = MoveZero(new int[] { 0 });

            foreach (int i in result)
            {
                Console.WriteLine(i);
            }
        }

        public int[] MoveZero(int[] nums)
        {
            if (nums.Length == 1) return nums;

            int index = 0;

            for(int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    int temp = nums[index];
                    nums[index] = nums[i];
                    nums[i] = temp;
                    index++;
                }
            }

            return nums;
        }
    }
}
