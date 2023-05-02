//using System;

//public class Node
//{
//    public int data;
//    public Node next;

//    public Node(int data)
//    {
//        this.data = data;
//        this.next = null;
//    }
//}

//public class Stack
//{
//    private Node top;

//    public void Push(int data)
//    {
//        Node newNode = new Node(data);
//        if (top == null)
//        {
//            top = newNode;
//        }
//        else
//        {
//            newNode.next = top;
//            top = newNode;
//        }
//    }

//    public int Pop()
//    {
//        if (top == null)
//        {
//            throw new InvalidOperationException("Stack is empty");
//        }
//        int data = top.data;
//        top = top.next;
//        return data;
//    }

//    public int Peek()
//    {
//        if (top == null)
//        {
//            throw new InvalidOperationException("Stack is empty");
//        }
//        return top.data;
//    }

//    public bool IsEmpty()
//    {
//        return top == null;
//    }
//}

//public class UC1
//{
//    public static void Main()
//    {
//        Stack stack = new Stack();
//        stack.Push(70);
//        stack.Push(30);
//        stack.Push(56);

//        Console.WriteLine(stack.Pop()); // prints 56
//        Console.WriteLine(stack.Pop()); // prints 30
//        Console.WriteLine(stack.Pop()); // prints 70
//    }
//}