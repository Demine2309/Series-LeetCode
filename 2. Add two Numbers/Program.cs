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
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode dummy = new ListNode();
            ListNode current = dummy;
            int carry = 0;

            while(l1 != null || l2 != null || carry != 0)
            {
                int sum = carry;

                if(l1 != null)
                {
                    sum += l1.val;
                    l1 = l1.next;
                }

                if(l2 != null)
                {
                    sum += l2.val;
                    l2 = l2.next;
                }

                carry = sum / 10;

                current.next = new ListNode(sum % 10);
                current = current.next;
            }

            return dummy.next;
        }

        public void PrintLinkedList(ListNode l)
        {
            ListNode current = l;

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

            ListNode l1 = new ListNode(9, new ListNode(9, new ListNode(9 , new ListNode(9, new ListNode(9, new ListNode(9))))));
            ListNode l2 = new ListNode(9, new ListNode(9, new ListNode(9)));

            Console.WriteLine("Original List 1:");
            solution.PrintLinkedList(l1);

            Console.WriteLine("Original List 2:");
            solution.PrintLinkedList(l2);

            Console.WriteLine("Result...");
            ListNode result = solution.AddTwoNumbers(l1, l2);
            solution.PrintLinkedList(result);

            Console.ReadLine();
        }
    }
}

/*
 *  Example 1:
    Input: l1 = [2,4,3], l2 = [5,6,4]
    Output: [7,0,8]
    Explanation: 342 + 465 = 807.

 * Example 2:
    Input: l1 = [0], l2 = [0]
    Output: [0]
 
 * Example 3:
    Input: l1 = [9,9,9,9,9,9,9], l2 = [9,9,9,9]
    Output: [8,9,9,9,0,0,0,1]
 */