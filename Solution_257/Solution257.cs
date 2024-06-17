namespace LeetCode.Solution_257
{
    public class Solution257
    {
        public void Main()
        {
            IList<string> result = new List<string>();
            TreeNode root = new TreeNode();

            GetBinaryTreePaths(root, root.val.ToString(), result);
        }

        public void GetBinaryTreePaths(TreeNode root, string temp, IList<string> result)
        {
            if (root == null) return;

            if(temp == "")
                temp += "->" + root.val.ToString();
            else
                temp += "->" + root.val.ToString();


            if (root.left == null && root.right == null)
            {
                result.Add(temp);
            }

            if(root.left != null)
                GetBinaryTreePaths(root.left, temp, result);
            if (root.right != null)
                GetBinaryTreePaths(root.right, temp, result);

        }
        public class TreeNode {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }
    }
}
