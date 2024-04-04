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

        public bool IsSymmetric(TreeNode root)
        {
            if (root == null) return true;

            return IsMirror(root.left, root.right);
        }

        private bool IsMirror(TreeNode left, TreeNode right)
        {
            if (left == null && right == null) return true;
            if (left == null || right == null) return false;

            return (left.val == right.val) && (IsMirror(left.left, right.right) && (IsMirror(left.right, right.left)));
        }
    }

    class MainClass
    {
        static void Main(string[] args)
        {
            Solution tree = new Solution();

            tree.root = new TreeNode(1);
            tree.root.left = new TreeNode(2);
            tree.root.right = new TreeNode(2);
            tree.root.left.left = new TreeNode(3);
            tree.root.left.right = new TreeNode(4);
            tree.root.right.left = new TreeNode(4);
            tree.root.right.right = new TreeNode(3);

            Console.WriteLine(tree.IsSymmetric(tree.root));
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