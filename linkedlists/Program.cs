using System;

namespace linkedlists
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            DLL dll = new DLL();
            dll.Add(5).Add(2).Add(3).Add(5).Add(6).Add(5).remove(5);
            dll.print();
            dll.reverse();
            dll.print();
        }
        public class Node
        {
            public int val {get; set;}
            public Node next {get; set;}
            public Node prev { get; set; }
            public Node(int val2)
            {
            val = val2;
            next = null;
            prev = null;
            }
        }
        public class DLL
        {
            public Node head {get; set;}
            public Node tail {get; set;}

            public DLL()
            {
                head = null;
                tail = null;
            }

            public DLL Add(int val)
            {
                Node newnode = new Node(val);
                if(this.head == null)
                {
                    this.head = newnode;
                    this.tail = this.head;
                }
                else
                {
                    this.tail.next = newnode;
                    newnode.prev = this.tail;
                    this.tail = newnode;
                }
                Console.WriteLine(newnode.val);
                return this;
            }
            public bool remove(int val2)
            {
                if(this.head == null)
                {
                    return false;
                }
                bool flag = false;
                while(this.head.val == val2)
                {
                    this.head = this.head.next;
                    this.head.prev = null;
                    flag = true;
                    Console.WriteLine(this.head.val);
                }
                while(this.tail.val == val2)
                {
                    this.tail = this.tail.prev;
                    this.tail.next = null;
                    Console.WriteLine(this.tail.val);
                }
                Node runner = this.head;
                while(runner.next != null)
                {
                    if(runner.val == val2)
                    {
                        Console.WriteLine(runner.val);
                        runner.next.prev = runner.prev;
                        runner = runner.prev;
                        runner.next = runner.next.next;
                    }
                    runner = runner.next;
                }
                return flag;
            }
            public void print(){
                Console.WriteLine("===================");
                Node runner = this.head;
                while(runner != null)
                {
                    Console.WriteLine(runner.val);
                    runner = runner.next;
                }
            }
            public DLL reverse(){
                Node runner = this.tail;
                while(runner != null)
                {
                    Node temp2 = runner.next;
                    runner.next = runner.prev;
                    runner.prev = temp2;
                    runner = runner.next;
                }
                Node temp = this.head;
                this.head = this.tail;
                this.tail = temp;
                return this;
            }
        }

    }

}
