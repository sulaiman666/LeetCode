using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LeetCode.Solution_268
{
    public class Solution268
    {
        public void Main()
        {
            MissingNumber(new[] { 3, 0, 1 });
            MissingNumber(new[] { 0, 1 });
            MissingNumber(new[] { 9, 6, 4, 2, 3, 5, 7, 0, 1 });
        }

        public int MissingNumber(int[] nums)
        {
            int temp = 0;

            for(int i = 0; i <= nums.Length; i++)
            {
                if (!nums.Contains(i))
                    temp = i;
            }

            return temp;
        }
    }
}
