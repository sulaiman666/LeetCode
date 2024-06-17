namespace LeetCode.Solution_345
{
    public class Solution345
    {
        public void Main()
        {
            string a = "hello";

            Console.WriteLine(ReverseVowels(a));
        }

        public string ReverseVowels(string s)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            char[] letters = s.ToCharArray();

            int[] index = new int[s.Length];
            int indexLength = 0;
            char temp;

            for (int i = 0; i < s.Length; i++)
            {
                if (vowels.Contains(Char.ToLower(s[i])))
                {
                    index[indexLength] = i;
                    indexLength++;
                }
            }

            for (int i = 0; i < indexLength / 2; i++)
            {
                temp = letters[index[i]];
                letters[index[i]] = letters[index[indexLength - i - 1]];
                letters[index[indexLength - i - 1]] = temp;
            }

            return new string(letters);
        }
    }
}
