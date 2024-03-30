namespace SeriesLeetCode
{
    // Definition for a binary tree node
    public class TreeNode
    {
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

    public class Solution
    {
        public IList<int> InorderTraversal(TreeNode node)
        {

        }
    }
}

/*
 * Example 1:
    Input: root = [1,null,2,3]
    Output: [1,3,2]
 
 * Example 2:
    Input: root = []
    Output: []
 * Example 3:
    Input: root = [1]
    Output: [1]
*/