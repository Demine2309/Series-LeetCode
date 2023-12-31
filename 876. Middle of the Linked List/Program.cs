﻿namespace SeriesLeetCode
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
        public ListNode MiddleNode(ListNode head)
        {
            ListNode temp = head;
            int lengthOfNode = GetCount(head) / 2;
            int middleNode;

            if (lengthOfNode % 2 == 0)
            {
                middleNode = (lengthOfNode / 2) + 1;
            }
            else
            {
                middleNode = (lengthOfNode + 1) / 2;
            }

            for(int i = middleNode; i <= lengthOfNode; i++)
            {
                if()
            }
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
        }
    }
}

/*
 * Example 1:
    Input: head = [1,2,3,4,5]
    Output: [3,4,5]
    Explanation: The middle node of the list is node 3.

 * Example 2:
    Input: head = [1,2,3,4,5,6]
    Output: [4,5,6]
    Explanation: Since the list has two middle nodes with values 3 and 4, we return the second one.
 */