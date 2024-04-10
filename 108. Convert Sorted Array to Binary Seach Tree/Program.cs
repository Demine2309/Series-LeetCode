using System.Runtime.ExceptionServices;

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
            if (nums == null || nums.Length == 0)
                return null;

            return SortedArrayToBSTRecursive(nums, 0, nums.Length - 1);
        }

        private TreeNode SortedArrayToBSTRecursive(int[] nums, int left, int right)
        {
            if (left > right)
            {
                return null;
            }

            int mid = left + (right - left) / 2;

            TreeNode root = new TreeNode(nums[mid]);

            root.left = SortedArrayToBSTRecursive(nums, left, mid - 1);
            root.right = SortedArrayToBSTRecursive(nums, mid + 1, right);

            return root;
        }

        public void LevelOrder(TreeNode root)
        {
            if (root == null) return;

            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                int levelSize = queue.Count;

                for (int i = 0; i < levelSize; i++)
                {
                    TreeNode current = queue.Dequeue();

                    Console.Write(current.val + " ");

                    if (current.left != null)
                        queue.Enqueue(current.left);

                    if (current.right != null)
                        queue.Enqueue(current.right);
                }
            }
        }
    }

    class MainClass
    {
        static void Main(string[] args)
        {
            Solution tree = new Solution();

            int[] nums = { -10, -3, 0, 5, 9 };

            tree.root = tree.SortedArrayToBST(nums);
            tree.LevelOrder(tree.root);
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