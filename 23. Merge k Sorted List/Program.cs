namespace SeriesLeetCode
{
    // Definition for singly-linked list
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
        public ListNode MergeKLists(ListNode[] lists)
        {
            if (lists == null || lists.Length == 0)
                return null;

            int interval = 1;
            while (interval < lists.Length)
            {
                for (int i = 0; i + interval < lists.Length; i += interval * 2)
                {
                    lists[i] = MergeTwoLists(lists[i], lists[i + interval]);
                }

                interval *= 2;
            }

            return lists[0];
        }

        private ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            ListNode dummy = new ListNode();
            ListNode tail = dummy;

            while (list1 != null && list2 != null)
            {
                if (list1.val < list2.val)
                {
                    tail.next = list1;
                    list1 = list1.next;
                }
                else
                {
                    tail.next = list2;
                    list2 = list2.next;
                }

                tail = tail.next;
            }

            // Append the remaining elements of list 1 or list 2
            if (list1 != null)
            {
                tail.next = list1;
            }
            else
            {
                tail.next = list2;
            }

            return dummy.next;
        }

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

            ListNode[] lists = new ListNode[]
            {
                new ListNode(1, new ListNode (2, new ListNode (5))),
                new ListNode(0, new ListNode (1, new ListNode (4))),
                new ListNode(2, new ListNode(6))
            };

            ListNode result = solution.MergeKLists(lists);

            solution.PrintLinkedList(result);
        }
    }
}

/*
 * Example 1:
    Input: lists = [[1,4,5],[1,3,4],[2,6]]
    Output: [1,1,2,3,4,4,5,6]
    Explanation: The linked-lists are:
    [
      1->4->5,
      1->3->4,
      2->6
    ]
    merging them into one sorted list:
    1->1->2->3->4->4->5->6

 * Example 2:
    Input: lists = []
    Output: []

 * Example 3:
    Input: lists = [[]]
    Output: []
*/