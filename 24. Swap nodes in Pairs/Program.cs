namespace SeriesLeetCode
{
    // Definition for singly-linked list.
    public class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    public class Solution
    {
        #region Recursive Approach
        //public ListNode SwapPairs(ListNode head)
        //{
        //    if (head == null || head.next == null)
        //        return head;

        //    ListNode newHead = head.next;

        //    head.next = SwapPairs(head.next.next);
        //    newHead.next = head;

        //    return newHead;
        //}
        #endregion

        #region Iterative Approach
        public ListNode SwapPairs(ListNode head)
        {
            ListNode dummy = new ListNode(0);
            dummy.next = head;

            ListNode prev = dummy;
            ListNode cur = head;

            while(cur != null && cur.next != null)
            {
                ListNode firstNode = cur;
                ListNode secondNode = cur.next;

                prev.next = secondNode;
                firstNode.next = secondNode.next;
                secondNode.next = firstNode;

                prev = firstNode;
                cur = firstNode.next;
            }

            return dummy.next;
        }
        #endregion

        public void PrintLinkedList(ListNode head)
        {
            ListNode current = head;

            while (current != null)
            {
                Console.Write(current.val + " -> ");
                current = current.next;
            }
            Console.WriteLine("null");
        }
    }

    class MainClass
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();

            ListNode head = new ListNode(1, new ListNode(2, new ListNode(5, new ListNode(4))));

            ListNode result = solution.SwapPairs(head);

            solution.PrintLinkedList(result);
        }
    }
}

/*
 * Example 1:
    Input: head = [1,2,3,4]
    Output: [2,1,4,3]

 * Example 2:
    Input: head = []
    Output: []

 * Example 3:
    Input: head = [1]
    Output: [1]
 */