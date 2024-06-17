namespace LeetCode.Solution_350
{
    public class Solution350
    {
        public void Main()
        {
            int[] print = Intersection(new int[] { 4, 9, 5 }, new int[] { 9, 4, 9, 8, 4 });

            foreach (int i in print)
            {
                Console.WriteLine(i);
            }
        }

        public int[] Intersection(int[] nums1, int[] nums2)
        {
            Dictionary<int, int> baseDictionary = new Dictionary<int, int>();
            List<int> result = new List<int>();

            int[] baseArray = nums1.Length > nums2.Length ? nums2 : nums1;
            int[] comparationArray = nums1.Length > nums2.Length ? nums1 : nums2;

            foreach (int baseNum in baseArray)
            {
                if(baseDictionary.ContainsKey(baseNum))
                {
                    baseDictionary[baseNum]++;
                }
                else
                {
                    baseDictionary.Add(baseNum, 1);
                }
            }

            foreach (int  comparationNum in comparationArray)
            {
                if (baseDictionary.ContainsKey(comparationNum) && baseDictionary[comparationNum] > 0)
                {
                    baseDictionary[comparationNum]--;
                    result.Add(comparationNum);
                }
            }

            return result.ToArray();
        }
    }
}
