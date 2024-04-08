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

        public TreeNode SortedArrayToBST(int[] nums)
        {

        }

        public void Inorder(TreeNode root, int[] nums)
        {
            if(root == null) return;

            Inorder(root.left, nums);
            Console.Write(root.val);
            Inorder(root.right, nums);
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
    Input: nums = [-10,-3,0,5,9]
    Output: [0,-3,9,-10,null,5]
    Explanation: [0,-10,5,null,-3,null,9] is also accepted:

 * Example 2:
    Input: nums = [1,3]
    Output: [3,1]
    Explanation: [1,null,3] and [3,1] are both height-balanced BSTs.
 */