namespace SeriesLeetCode
{
    public class TreeNode
    {
        public int val;
        public TreeNode left, right;

        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    public class Solution
    {
        public TreeNode root;

        public bool IsBalanced(TreeNode root)
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
    Input: root = [3,9,20,null,null,15,7]
    Output: true

 * Example 2:
    Input: root = [1,2,2,3,3,null,null,4,4]
    Output: false

 * Example 3:
    Input: root = []
    Output: true
*/