using System.Xml.Linq;

namespace SeriesLeetCode
{
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
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            int m = GetCount(head) - n + 1;

            ListNode temp = head;
            ListNode prev = head;

            for (int i = 0; i < m; i++)
            {
                if (i == 0 && m == 1)
                {
                    head = head.next;
                    temp = null;
                }
                else
                {
                    if (i == m - 1 && temp != null)
                    {
                        prev.next = temp.next;
                        temp = null;
                    }
                    else
                    {
                        prev = temp;

                        // Position was greater than number of nodes in the list
                        if (prev == null)
                            break;
                        temp = temp.next;
                    }
                }
            }

            return head;
        }

        private int GetCount(ListNode node)
        {
            if (node == null) return 0;

            return 1 + GetCount(node.next);
        }

        public void Print(ListNode head)
        {
            ListNode temp = head;
            while (temp != null)
            {
                Console.Write(temp.val + " -> ");
                temp = temp.next;
            }
            Console.Write("null\n");
        }
    }

    class MainClass
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();

            ListNode head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));
            ListNode result = solution.RemoveNthFromEnd(head, 2);

            solution.Print(head);
        }
    }
}

/*
 * Example 1:
    Input: head = [1,2,3,4,5], n = 2
    Output: [1,2,3,5]

 * Example 2:
    Input: head = [1], n = 1
    Output: []

 * Example 3:
    Input: head = [1,2], n = 1
    Output: [1] 
*/