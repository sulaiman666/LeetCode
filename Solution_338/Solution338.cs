using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LeetCode.Solution_338
{
    public class Solution338
    {
        public void Main()
        {
            int[] number = CountBits(0);

            foreach (int digit in number)
            {
                Console.WriteLine(digit);
            }

            Console.WriteLine();

            number = CountBits(2);

            foreach (int digit in number)
            {
                Console.WriteLine(digit);
            }

            Console.WriteLine();

            number = CountBits(5);

            foreach (int digit in number)
            {
                Console.WriteLine(digit);
            }
        }
        public int[] CountBits(int n)
        {
            int[] result = new int[n + 1];
            int rowResult;
            int digit;

            for (int i = 0; i <= n; i++)
            {
                digit = i;
                rowResult = 0;

                do
                {
                    if(digit % 2 == 1)
                    {
                        rowResult++;
                    }
                    digit /= 2;
                }
                while (digit > 0);

                result[i] = rowResult;
            }
            return result;
        }
    }
}
