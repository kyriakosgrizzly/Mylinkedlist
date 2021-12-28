using System;

namespace Mylinkedlist
{
    class Program
    {
        static void Main(string[] args)
        {
            Linkedlist<int> list = new Linkedlist<int>(10);
            list.push(1);
            list.push(2);
            list.push(3);
            list.remove(0);
            list.display();
            list.replace(0, 5);
            list.display();
            Console.WriteLine(list.length);
        }
    }
}
