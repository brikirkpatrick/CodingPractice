using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DSAndAlgos.DataStructures.LinkedLists
{
    // TODO: Describe Space time complexity of solutions
    public class LC_LinkedListTests
    {
        //Reverse a LinkedList:https://leetcode.com/problems/reverse-linked-list/
        //Input: head = [1,2,3,4,5]
        //Output: [5,4,3,2,1]
        public ListNode ReverseList(ListNode head)
        {
            ListNode newHead = null; // will hold new list.
            ListNode prev = null; // keep track of previous ListNode of newHead;

            while (head != null)
            {
                prev = newHead;
                newHead = new ListNode(head.val);
                newHead.next = prev;
                head = head.next;
            }
            return newHead;
        }

        [Test]
        public void ReverseListTest()
        {
            ListNode head = new ListNode(1);
            head.next = new ListNode(2);
            head.next.next = new ListNode(3);
            head.next.next.next = new ListNode(4);
            head.next.next.next.next = new ListNode(5);

            var tempListNode = head;
            Console.Write("Ori List: ");
            while(tempListNode != null)
            {
                Console.Write("{0} ", tempListNode.val);
                tempListNode = tempListNode.next;
            }

            // True Test
            ListNode newHead = ReverseList(head);
            tempListNode = head;
            Console.Write("\nNew List: ");
            while (tempListNode != null)
            {
                Console.Write("{0} ", tempListNode.val);
                tempListNode = tempListNode.next;
            }
        }

        // TODO REVIEW
        // LinkedList Cylce: https://leetcode.com/problems/linked-list-cycle/
        // Input: head = [3,2,0,-4], pos = 1
        // Output: true
        // Explanation: There is a cycle in the linked list, where the tail connects to the 1st node(0-indexed).
        // Hint: Floyds Clycle Detection Algorithm (Fasy & Slow Pointer)
        public bool HasCycle(ListNode head)
        {
            ListNode fast = head;
            ListNode slow = head;

            while(fast != null && fast.next != null)
            {
                fast = fast.next.next;
                slow = slow.next;
                if (fast == slow) return true;
            }

            return false;
        }

        // TODO: Review (This could be solved recursively)
        // Merge Two Sorted Lists: https://leetcode.com/problems/merge-two-sorted-lists/
        // Input: l1 = [1,2,4], l2 = [1,3,4]
        // Output: [1,1,2,3,4,4]
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            if (l1 == null) return l2;
            if (l2 == null) return l1;

            ListNode result;

            if (l1.val < l2.val)
            {
                result = l1;
                result.next = MergeTwoLists(l1.next, l2);
            }
            else
            {
                result = l2;
                result.next = MergeTwoLists(l1, l2.next);
            }

            return result;
        }

        [Test]
        public void MergeTwoListsTest()
        {
            var l1 = new ListNode(1);
            l1.next = new ListNode(2);
            l1.next.next = new ListNode(4);

            var l2 = new ListNode(1);
            l2.next = new ListNode(3);
            l2.next.next = new ListNode(4);

            var newList = MergeTwoLists(l1, l2);
            Console.Write("\nNew List: ");
            while (newList != null)
            {
                Console.Write("{0} ", newList.val);
                newList = newList.next;
            }
        }

        // Middle Node of Linked List: https://leetcode.com/problems/middle-of-the-linked-list/
        // Input: head = [1,2,3,4,5]
        // Output: [3,4,5]
        // Input: head = [1,2,3,4,5,6] //if fast can move forward atleast once, then slow moves foward.
        // Output: [4,5,6]
        public ListNode MiddleNode(ListNode head)
        {
            ListNode fast = head, slow = head;

            while(fast != null && fast.next != null) // while this break?
            {
                fast = fast.next.next; //5
                slow = slow.next; //3
            }

            return slow;
        }

        [Test]
        public void MiddleNodeTest()
        {
            var l1 = new ListNode(1);
            l1.next = new ListNode(2);
            l1.next.next = new ListNode(3);
            l1.next.next.next = new ListNode(4);
            l1.next.next.next.next = new ListNode(5);
            l1.next.next.next.next.next = new ListNode(6);

            var result = MiddleNode(l1);
            Console.Write("\nNew List: ");
            while (result != null)
            {
                Console.Write("{0} ", result.val);
                result = result.next;
            }
        }

        // Remove Duplicates from Sorted List:https://leetcode.com/problems/remove-duplicates-from-sorted-list/
        // Input: head = [1,1,2]
        // Output: [1,2]
        public ListNode DeleteDuplicates(ListNode head)
        {
            ListNode prev = null;
            ListNode curr = head;

            while(curr != null)
            {
                if (curr == prev) // 1 == 1
                {
                    // link prev -> next
                    prev.next = curr.next; // 2
                }
                prev = curr; // 1, 1
                curr = curr.next; //1, 2
            }

            return null;
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }

        public ListNode(int x)
        {
            val = x;
            next = null;
        }
    }
}
