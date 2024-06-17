namespace LeetCode.Solution_344
{
    public class Solution344
    {
        public void Main()
        {
            char[] a = { 'h', 'e', 'l', 'l', 'o' };

            ReverseString(a);

            Console.WriteLine();
        }

        public void ReverseString(char[] s)
        {
            char temp;
            for (int i = 0; i < s.Length / 2; i++)
            {
                temp = s[i];
                s[i] = s[s.Length - i - 1];
                s[s.Length - i - 1] = temp;
            }
        }

        public void ReverseStringTuple(char[] s)
        {
            char temp;
            for (int i = 0; i < s.Length / 2; i++)
            {
                (s[i], s[s.Length - i - 1]) = (s[s.Length - i - 1], s[i]);
            }
        }
    }
}
