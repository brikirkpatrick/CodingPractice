using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAndAlgorithms.DataStructures.LinkedLists
{
    [TestFixture]
    public class LinkedListTests
    {
        [Test]
        public void SinglyLinkedListWorks()
        {
            SinglyLinkedList list = new SinglyLinkedList();
            int val = list.Get(0);
            Assert.AreEqual(-1, val);

            //list.AddAtHead(2);

            //list.AddAtTail(3);

            //list.AddAtIndex(1, 5);

            //list.DeleteAtIndex(0);

        }
    }
}
