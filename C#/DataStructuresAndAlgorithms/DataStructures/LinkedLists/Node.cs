using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAndAlgorithms.DataStructures.LinkedLists
{
    public class Node
    {
        // A node in a singly linked list should have two attributes: val and next. val is the value of the current node, and next is a pointer/reference to the next node.
        public Node Next { get; set; }
        public int Value { get; set; }
    }
}
