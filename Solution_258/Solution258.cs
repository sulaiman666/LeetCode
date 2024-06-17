namespace LeetCode.Solution_258
{
    public class Solution258
    {
        public void Main()
        {
            AddDigits(38);
            AddDigits(0);
            AddDigits(19);
        }

        public void AddDigits(int num)
        {
            int result = 0;
            do
            {
                result = 0;
                while (num > 0)
                {
                    result += num % 10;
                    num /= 10;
                }
                num = result;
            }
            while (result >= 10);

            Console.WriteLine(result);
        }
    }
}
