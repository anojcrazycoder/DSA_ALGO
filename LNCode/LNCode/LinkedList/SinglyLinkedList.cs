using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LNCode.LinkedList
{
    public class Node
    {
        public int data { get; set; }
        public Node next { get; set; }
        public Node(int data)
        {
            this.data = data;
            this.next = null;
        }
    }
    internal class SinglyLinkedList
    {
        private Node head;
        public SinglyLinkedList()
        {
            head = null;

        }
        public void AddLast(int data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node current = head;
            }

        }

    }
}
