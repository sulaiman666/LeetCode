namespace LeetCode.Solution_290
{
    public class Solution290
    {
        public void Main()
        {
            Console.WriteLine(WordPattern("abba", "dog cat cat dog"));
            Console.WriteLine(WordPattern("abba", "dog cat cat fish"));
        }

        public bool WordPattern(string pattern, string s)
        {
            char[] chars = pattern.ToCharArray().Distinct().ToArray();

            Dictionary<string, char> stringToChar = new Dictionary<string, char>();

            string[] sArray = s.Split(' ');
            int index = 0;
            string patternResult = "";

            foreach(string word in sArray)
            {
                if(index == chars.Length && !stringToChar.ContainsKey(word)) 
                    return false;
                else if (!stringToChar.ContainsKey(word))
                {
                    stringToChar.Add(word, chars[index]);
                    index++;
                }

                patternResult += stringToChar[word];
            }

            return pattern == patternResult;
        }
    }
}
