namespace SeriesLeetCode
{
    #region Way 1
    //public class ListNode
    //{
    //    public int value;
    //    public ListNode next = null;
    //    public ListNode(int val = 0)
    //    {
    //        value = val;
    //        next = null;
    //    }
    //}
    #endregion

    #region Way 2
    public class ListNode
    {
        public int value;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            value = val;
            this.next = next;
        }
    }
    #endregion

    public class Solution
    {
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            ListNode dummy = new ListNode();
            ListNode tail = dummy;

            while (list1 != null && list2 != null)
            {
                if (list1.value < list2.value)
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
                Console.Write(current.value + " -> ");
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

            #region Way 1
            //// Creating two sorted linked lists
            //ListNode list1 = new ListNode(1);
            //list1.next = new ListNode(3);
            //list1.next.next = new ListNode(5);

            //ListNode list2 = new ListNode(2);
            //list2.next = new ListNode(4);
            //list2.next.next = new ListNode(6);
            #endregion

            #region Way 2
            ListNode list1 = new ListNode(1, new ListNode(3, new ListNode(5)));
            ListNode list2 = new ListNode(2, new ListNode(4, new ListNode(6)));
            #endregion

            Console.WriteLine("Original List 1:");
            solution.PrintLinkedList(list1);

            Console.WriteLine("Original List 2:");
            solution.PrintLinkedList(list2);

            // Merge the two sorted lists
            ListNode mergedList = solution.MergeTwoLists(list1, list2);

            Console.WriteLine("Merged List:");
            solution.PrintLinkedList(mergedList);
        }
    }
}