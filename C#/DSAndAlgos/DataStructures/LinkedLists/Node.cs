using System;
using System.Collections.Generic;
using System.Text;

namespace DSAndAlgos.DataStructures.LinkedLists
{
    // A node in a singly linked list should have two attributes: val and next. val is the value of the current node, and next is a pointer/reference to the next node.
    public class Node
    {
        public int Value { get; set; }
        public Node Next { get; set; }

        public Node(int val)
        {
            Value = val;
        }
    }
}
