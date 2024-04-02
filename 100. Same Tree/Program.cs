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
        public bool IsSameTree(TreeNode p, TreeNode q)
        {
                
        }
    }
}

/*
 * Example 1:
    Input: p = [1,2,3], q = [1,2,3]
    Output: true

 * Example 2:
    Input: p = [1,2], q = [1,null,2]
    Output: false

 * Example 3:
    Input: p = [1,2,1], q = [1,1,2]
    Output: false
 */