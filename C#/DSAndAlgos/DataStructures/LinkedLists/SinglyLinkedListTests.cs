using NUnit.Framework;
using System;

namespace DSAndAlgos.DataStructures.LinkedLists
{
    public class SinglyLinkedListTests
    {
        [Test]
        public void AddAtHeadWorks()
        {
            var list = new SinglyLinkedList();

            // First Head
            list.AddAtHead(5);
            var headVal = list.Get(0);
            Assert.AreEqual(5, headVal);

            // Update Head
            list.AddAtHead(10);
            headVal = list.Get(0);
            Assert.AreEqual(10, headVal);
        }

        [Test]
        public void GetWorks()
        {
            var list = new SinglyLinkedList();


            //Verify Head isn't null
            int val = list.Get(0);
            Assert.AreEqual(-1, val);
        }

        [Test]
        public void AddAtIndexWorks()
        {
            var list = new SinglyLinkedList();
            list.AddAtHead(1); 
            list.AddAtIndex(0, 0); 
            Assert.AreEqual(0, list.Get(0));
            Assert.AreEqual(1, list.Get(1)); // List {0, 1}

            list.AddAtIndex(1, 1); // List {0, 1, 1}
            Assert.AreEqual(1, list.Get(1));

            list.AddAtIndex(1, 3); // List {0, 3, 1, 1}
            Assert.AreEqual(3, list.Get(1));
            Assert.AreEqual(4, list.Length);

            list.AddAtIndex(20, 5);
            Assert.AreEqual(4, list.Length); // length shouldn't have changed.


            for (int i = 0; i < list.Length; i++)
            {
                Console.WriteLine("Item " + i + ": " + list.Get(i));
            }
        }

        [Test]
        public void AddAtTailWorks()
        {
            var list = new SinglyLinkedList();
            list.AddAtTail(0);
            list.AddAtTail(1); // List {0, 1}

            Assert.AreEqual(1, list.Get(1));
        }

        [Test]
        public void DeleteAtIndexWorks()
        {
            var list = new SinglyLinkedList();
            list.AddAtHead(1);
            list.AddAtIndex(0, 0);
            list.AddAtIndex(1, 1); // List {0, 1, 1}
            Assert.AreEqual(3, list.Length);

            list.DeleteAtIndex(1);
            Assert.AreEqual(1, list.Get(1)); // List {0, 1}
            Assert.AreEqual(2, list.Length);

            list.DeleteAtIndex(1);
            Assert.AreEqual(-1, list.Get(1)); // List {0}
            Assert.AreEqual(0, list.Get(0));
            Assert.AreEqual(1, list.Length);
        }

        [Test]
        public void LeetCodeTest()
        {
            /*
             
["MyLinkedList","addAtHead","addAtHead","addAtHead","addAtIndex","deleteAtIndex","addAtHead","addAtTail","get","addAtHead","addAtIndex","addAtHead"]
[[],[7],[2],[1],[3,0],[2],[6],[4],[4],[4],[5,0],[6]]
             */
            var list = new SinglyLinkedList();
            list.AddAtHead(7);
            list.AddAtHead(2);
            list.AddAtHead(1); // List {1, 2, 7}
            list.AddAtIndex(3, 0); //{1,2,7,0}
            for (int i = 0; i < list.Length; i++)
            {
                Console.WriteLine("Item " + i + ": " + list.Get(i));
            }

            list.DeleteAtIndex(2);
            list.AddAtHead(6);
            list.AddAtTail(4);


            //for (int i = 0; i < list.Length; i++)
            //{
            //    Console.WriteLine("Item " + i + ": " + list.Get(i) + ", ");
            //}

            Assert.AreEqual(4, list.Get(4));
        }
    }
}
