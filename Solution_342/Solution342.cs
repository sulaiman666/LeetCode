namespace LeetCode.Solution_342
{
    public class Solution342
    {
        public void Main()
        {
            Console.WriteLine(IsPowerOfFour(30));
        }

        public bool IsPowerOfFour(int n)
        {
            if (n == 1) return true;
            if (n % 4 != 0) return false;

            while (n > 4 && n % 4 == 0)
            {
                n /= 4;
            }

            return n == 4;
        }
    }
}
