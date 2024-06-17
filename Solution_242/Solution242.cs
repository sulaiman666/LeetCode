namespace LeetCode.Solution_242
{
    public class Solution242
    {
        public void Main()
        {
            Console.WriteLine(IsAnagram("anagram", "anagram"));

            Console.WriteLine(IsAnagram("rat", "car"));
        }

        public bool IsAnagram(string s, string t) // Other Solution With New Something to Learn (Memory Consumption and Run time is average)
        {
            if (s.Length != t.Length)
                return false;

            Dictionary<char, int> charCount = new Dictionary<char, int>();

            for (int i = 0; i < s.Length; i++)
            {
                charCount.TryAdd(s[i], 0); // New Function Learned
                charCount.TryAdd(t[i], 0);

                charCount[s[i]]++;
                charCount[t[i]]--;
            }

            return charCount.Values.All(x => x == 0); // New Function Learned
        }

        public bool IsAnagram0(string s, string t) // My Solution (Memory Consumption High and Run time also High)
        {
            return new string(s.OrderBy(x => x).ToArray()) == new string(t.OrderBy(x => x).ToArray());
        }
    }
}
