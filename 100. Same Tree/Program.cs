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
        public TreeNode rootP, rootQ;

        public bool IsSameTree(TreeNode p, TreeNode q)
        {
            if(p == null && q == null) return true;

            if(p == null || q == null) return false;

            if(p.val != q.val) return false;

            return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
        }
    }

    class MainClass
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();

            solution.rootP = new TreeNode(1);
            solution.rootP.left = new TreeNode(1);

            solution.rootQ = new TreeNode(1);
            solution.rootQ.right = new TreeNode(1);

            Console.WriteLine(solution.IsSameTree(solution.rootP, solution.rootQ));
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