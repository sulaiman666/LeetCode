using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solution_278
{
    public class Solution278
    {
        public void Main()
        {
            Console.WriteLine(FirstBadVersion(4));
            FirstBadVersion(1);
        }

        public int FirstBadVersion(int n)
        {
            if (n == 1) return n;
            else
            {
                int result = 0;
                int middle = n / 2;
                if (IsBadVersion(middle))
                {
                    for (int i = middle; 1 <= i; i--)
                    {
                        if (IsBadVersion(i)) result = i;
                    }
                }
                else
                {
                    for (int i = middle; i <= n; i++)
                    {
                        if (IsBadVersion(i)) return i;
                    }
                }
                return result;
            }
        }

        public bool IsBadVersion(int version)
        {
            return version >= 1;
        }
    }
}
