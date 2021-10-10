using System;
using System.Collections.Generic;
using System.Text;

namespace DSAndAlgos.DataStructures.LinkedLists
{
    public class SinglyLinkedList
    {
        private Node _head;
        public int Length;

        /** Initialize your data structure here. */
        public SinglyLinkedList()
        {
            Length = 0;
        }

        /** Get the value of the index-th node in the linked list. If the index is invalid, return -1. */
        // list = {0, 1, 2}, index = 0, we should return 0
        public int Get(int index)
        {
            if (_head == null || index > Length - 1)
            {
                return -1;
            }
            else if (index == 0)
            {
                return _head.Value;
            }
            else {
                var node = _head;
                for (int i = 0; i < index; i++)
                {
                    node = node.Next;
                }
                return node.Value;
            }
        }

        /** Add a node of value val before the first element of the linked list. After the insertion, the new node will be the first node of the linked list. */
        public void AddAtHead(int val)
        {
            if (_head == null)
            {
                _head = new Node(val);
                Length++;
            }
            else
            {
                var newNode = new Node(val);
                newNode.Next = _head;
                _head = newNode;
                Length++;
            }
        }

        /** Append a node of value val to the last element of the linked list. */
        public void AddAtTail(int val)
        {
            if (Length == 0)
            {
                AddAtHead(val);
            }
            else
            {
                var newNode = new Node(val);
                var tempNode = _head;
                while(tempNode.Next != null)
                {
                    tempNode = tempNode.Next;
                }
                tempNode.Next = newNode;
                Length++;
            }
        }

        //Big Note: This method is more an Update of existing items.
        /** Add a node of value val before the index-th node in the linked list. If index equals to the length of linked list, 
         * the node will be appended to the end of linked list. If index is greater than the length, the node will not be inserted. */
        public void AddAtIndex(int index, int val)
        {
            var newNode = new Node(val);
            
            if (index == 0)
            {
                if (_head == null)
                {
                    AddAtHead(newNode.Value);
                }
                else
                {
                    // make newNode the head.
                    var tempHead = _head;
                    newNode.Next = tempHead;
                    _head = newNode;
                    Length++;
                }
            }
            else if (index <= Length - 1)
            {
                // List = {1, 2, 3, 5}, Want to add (index = 2, val = 4), List should = {1, 2, 4, 3, 5}
                var prevNode = _head;
                for (int i = 0; i < index - 1; i++)
                {
                    prevNode = prevNode.Next; // if index = 2, this is val 2
                }
                var nextNode = prevNode.Next; // this is 3
                prevNode.Next = newNode; // List = {1, 2, 4}
                newNode.Next = nextNode; // List = {1, 2, 4, 3, 5}
                Length++;
            }
            else if (index == Length)
            {
                AddAtTail(val);
            }
            else if (index > Length - 1)
            {
                return;
            }
        }

        /** Delete the index-th node in the linked list, if the index is valid. */
        public void DeleteAtIndex(int index)
        {
            if (index > Length - 1 || _head == null)
            {
                return;
            }
            if (index == 0)
            {
                _head = _head.Next;
            }
            else
            {
                // List = {1, 2, 3, 5}, Want to delete index = 3, List should = {1, 2, 3}
                var prevNode = _head;
                for (int i = 0; i < index - 1; i++)
                {
                    prevNode = prevNode.Next;
                }
                var nextNode = prevNode.Next.Next;
                prevNode.Next = nextNode;
                Length--;
            }
        }
    }

    /**
     * Your MyLinkedList object will be instantiated and called as such:
     * MyLinkedList obj = new MyLinkedList();
     * int param_1 = obj.Get(index);
     * obj.AddAtHead(val);
     * obj.AddAtTail(val);
     * obj.AddAtIndex(index,val);
     * obj.DeleteAtIndex(index);
     */
}
