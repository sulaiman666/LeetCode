namespace LeetCode.Solution_349
{
    public class Solution349
    {
        public void Main()
        {
            int[] print = Intersection(new int[] { 1, 2, 2, 1 }, new int[] { 2, 2 });

            foreach (int i in print)
            {
                Console.WriteLine(i);
            }
        }

        public int[] Intersection(int[] nums1, int[] nums2)
        {
            HashSet<int> nums1Set = new HashSet<int>();
            HashSet<int> intersectionSet = new HashSet<int>();

            foreach(int num1 in nums1)
            {
                nums1Set.Add(num1);
            }

            foreach (int num2 in nums2)
            {
                if(nums1Set.Contains(num2))
                {
                    intersectionSet.Add(num2);
                }
            }

            int[] result = new int[intersectionSet.Count];
            int i = 0;

            foreach(int intersect in intersectionSet)
            {
                result[i] = intersect;
                i++;
            }

            return result;
        }
    }
}
