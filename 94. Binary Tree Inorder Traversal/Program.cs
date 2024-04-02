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
        public TreeNode root;

        public IList<int> InorderTraversal(TreeNode node)
        {
            IList<int> result = new List<int>();
            Inorder(node, result);

            return result;
        }

        private void Inorder(TreeNode node, IList<int> result)
        {
            if (node == null)
                return;

            Inorder(node.left, result);
            result.Add(node.val);
            Inorder(node.right, result);
        }

        public void PrintResult(IList<int> list)
        {
            Console.Write("[");
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i]);
                if (i < list.Count - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine("]");
        }
    }

    class MainClass
    {
        static void Main(string[] args)
        {
            Solution tree = new Solution();

            tree.root = new TreeNode(1);
            tree.root.right = new TreeNode(2);
            tree.root.right.left = new TreeNode(3);

            tree.PrintResult(tree.InorderTraversal(tree.root));
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