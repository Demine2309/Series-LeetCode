namespace SeriesLeetCode
{
    public class TreeNode
    {
        public int val;
        public TreeNode left, right;

        public TreeNode(int val, TreeNode left, TreeNode right)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    public class Solution
    {
        public TreeNode root;

        public bool IsSymmetric(TreeNode root)
        {

        }
    }

    class MainClass
    {
        static void Main(string[] args)
        {
            Solution tree = new Solution();


        }
    }
}

/*
 * Example 1:
    Input: root = [1,2,2,3,4,4,3]
    Output: true

 * Example 2:
    Input: root = [1,2,2,null,3,null,3]
    Output: false
 */