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

        public int MaxDepth(TreeNode root)
        {
            if(root == null) return 0;

            int leftDepth = MaxDepth(root.left);

            int rightDepth = MaxDepth(root.right);

            return Math.Max(leftDepth, rightDepth) + 1;
        }
    }

    class MainClass
    {
        static void Main(string[] args)
        {
            Solution tree = new Solution();

            tree.root = new TreeNode(3);
            tree.root.left = new TreeNode(9);
            tree.root.right = new TreeNode(20);
            tree.root.right.left = new TreeNode(15);
            tree.root.right.right = new TreeNode(7);

            Console.WriteLine(tree.MaxDepth(tree.root));
        }
    }
}

/*
 * Example 1:
    Input: root = [3,9,20,null,null,15,7]
    Output: 3

 * Example 2:
    Input: root = [1,null,2]
    Output: 2
 */