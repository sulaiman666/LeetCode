using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solution_291
{
    public class Solution291
    {
        public class NumArray
        {
            private int[] _nums;
            public NumArray(int[] nums)
            {
                _nums = nums;
            }

            public int SumRange(int left, int right)
            {
                int result = 0;
                for (int i = left; i <= right; i++)
                {
                    result += _nums[i];
                }
                return result;
            }
        }

        public void Main()
        {
            NumArray obj = new NumArray(new int[] { -2, 0, 3, -5, 2, -1 });
        }
    }
}
