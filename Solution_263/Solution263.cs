namespace LeetCode.Solution_263
{
    public class Solution263
    {
        public void Main()
        {
            Console.WriteLine(IsUgly(6));
            Console.WriteLine(IsUgly(1));
            Console.WriteLine(IsUgly(14));
        }

        public bool IsUgly(int n)
        {
            if (n == 0) return false;

            while (n % 2 == 0)
                n /= 2;
            while (n % 3 == 0)
                n /= 3;
            while (n % 5 == 0)
                n /= 5;

            return n == 1;
        }
    }
}
