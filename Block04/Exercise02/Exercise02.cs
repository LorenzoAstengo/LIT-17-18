using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02
{
    public class SimpleLinkedList<T>
    {
        private static int counter;
        public static int Counter
        {
            get { return counter; }
            set { counter = value; }
        }

        private Node head;
        public Node Head
        {
            get { return Head; }
            set { Head = value; }
        }

        private Node lastNode;
        public Node LastNode
        {
            get { return lastNode; }
            set { lastNode = value; }
        }

        public SimpleLinkedList()
        {
            lastNode = null;
        }

        public class Node
        {
            private Node nextNode;
            public Node NextNode
            {
                get { return nextNode; }
                set { nextNode = value; }
            }

            private T data;
            public T Data
            {
                get { return data; }
                set { data = value; }
            }

            public Node(T data)
            {
                this.data = data;
            }

            public Node(Node node)
            {
                data = node.data;
                nextNode = node.nextNode;
            }
        }

        public void AddNode(T data)
        {
            if (LastNode == null)
            {
                LastNode = head = new Node(data);
            }
            else
            {
                head = lastNode;
                lastNode = new Node(data);
                lastNode.NextNode = head;                
            }
            counter++;
        }

        public void AddNode(Node node)
        {
            head = lastNode;
            lastNode = node;
            lastNode.NextNode = head;
        }

        public SimpleLinkedList<T> Reverse()
        {
            SimpleLinkedList<T> reversedList = new SimpleLinkedList<T>();
            Node current = new Node(lastNode);
            Node next = new Node(lastNode.NextNode);
            reversedList.AddNode(current);
            reversedList.lastNode.NextNode = null;
            current = next;
            for(int i = 0; i <= counter - 2; i++) 
            {
                if (current.NextNode != null)
                {
                    next = current.NextNode;
                    reversedList.AddNode(current);
                    current = next;
                }
                else
                {
                    next = reversedList.lastNode;       //finally using next to set the lastnode.nextnode
                    reversedList.AddNode(current);
                    reversedList.lastNode.NextNode = next;
                }
            }
            return reversedList;
        }

        public T[] ToArray()
        {
            T[] array = new T[counter];
            Node current = lastNode;

            for (int i = 0; i < counter; i++)
            {
                if (current.NextNode != null)
                {
                    array[i] = current.Data;
                    current = current.NextNode;
                }
                else
                {
                    array[i] = current.Data;
                }
            }
            return array;
        }
    }
}
