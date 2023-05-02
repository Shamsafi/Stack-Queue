//using System;

//public class Node
//{
//    public int data;
//    public Node next;
//    public Node(int d)
//    {
//        data = d;
//        next = null;
//    }
//}

//public class Stack
//{
//    public Node top;
//    public Stack()
//    {
//        top = null;
//    }
//    public void Push(int data)
//    {
//        Node newNode = new Node(data);
//        newNode.next = top;
//        top = newNode;
//    }
//    public int Pop()
//    {
//        if (top == null)
//        {
//            Console.WriteLine("Stack is empty");
//            return -1;
//        }
//        else
//        {
//            int data = top.data;
//            top = top.next;
//            return data;
//        }
//    }
//    public int Peek()
//    {
//        if (top == null)
//        {
//            Console.WriteLine("Stack is empty");
//            return -1;
//        }
//        else
//        {
//            return top.data;
//        }
//    }
//}

//public class Program
//{
//    public static void Main()
//    {
//        Stack stack = new Stack();
//        stack.Push(56);
//        stack.Push(30);
//        stack.Push(70);
//        Console.WriteLine("Elements in the stack:");
//        while (stack.top != null)
//        {
//            Console.WriteLine("Peek: " + stack.Peek());
//            Console.WriteLine("Pop: " + stack.Pop());
//        }
//    }
//}