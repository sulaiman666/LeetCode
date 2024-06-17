using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solution_351
{
    public class Solution_351
    {
        public void main()
        {

        }

        public bool IsPerfectSquare(int num)
        {
            int result = 1;
            while (result * result < num)
            {
                result++;
            }
            return result * result == num;
        }
    }
}
