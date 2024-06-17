using static LeetCode.Solution_291.Solution291;

namespace LeetCode.Solution_326
{
    public class Solution326
    {
        public void Main()
        {
            Console.WriteLine(IsPowerOfThree(30));
        }

        public bool IsPowerOfThree(int n)
        {
            if (n % 3 != 0) return false;
            if (n == 1) return true;

            while (n > 3 && n % 3 == 0)
            {
                n /= 3;
            }

            return n == 3;
        }
    }
}
