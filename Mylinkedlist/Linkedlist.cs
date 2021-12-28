using System;
using System.Collections.Generic;
using System.Text;

namespace Mylinkedlist
{
    class Linkedlist<T>
    { 
        class Node
        {
            public T Value { get; set; }
            public Node nextNode {get;set;}

            public Node prevNode { get; set; }
            public Node()
            {
                nextNode = null;
                prevNode = null;
            }
        }
        private Node Head;
        public int length;
        public Linkedlist(T val)
        {
            Head = new Node();
            Head.Value = val;
            length++;
        }
        private Node Find(int index)
        {
            if (index >= length) return null;
            Node tmp = Head;
            for (int i = 0; i < index; i++)
            {
                tmp = tmp.nextNode;
            }
            return tmp;
        }
        public void push(T val)
        {
            Node tmp = Find(length - 1);
            Node newnode = new Node();
            tmp.nextNode = newnode;
            newnode.prevNode = tmp;
            newnode.Value = val;
            length++;
        }
        public void replace(int index,T val)
        {
            Find(index).Value = val;
        }
        public T get(int index)
        {
            return Find(index).Value;
        }
        public void remove(int index)
        {
            Node tmp = Find(index);
            Node prev = tmp.prevNode;
            Node next = tmp.nextNode;
            if(index != 0 && index != length - 1)
            {
                prev.nextNode = next;
                next.prevNode = prev;
            }
            else
            {
                if(index != 0)
                {
                    prev.nextNode = null;
                }
                else if(index != length - 1)
                {
                    Head = tmp.nextNode;
                }
                else
                {
                    return;
                }
            }
            length--;
        }
        public void display()
        {
            Node tmp = Head;
            while(tmp != null)
            {
                Console.Write(tmp.Value + " ");
                tmp = tmp.nextNode;
            }
            Console.WriteLine();
        }
    }
}
