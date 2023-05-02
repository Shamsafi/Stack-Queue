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

//public class Queue
//{
//    private Node front;
//    private Node rear;

//    public void Enqueue(int data)
//    {
//        Node newNode = new Node(data);
//        if (front == null)
//        {
//            front = newNode;
//            rear = newNode;
//        }
//        else
//        {
//            rear.next = newNode;
//            rear = newNode;
//        }
//    }

//    public int Dequeue()
//    {
//        if (front == null)
//        {
//            throw new InvalidOperationException("Queue is empty");
//        }
//        int data = front.data;
//        front = front.next;
//        if (front == null)
//        {
//            rear = null;
//        }
//        return data;
//    }

//    public int Peek()
//    {
//        if (front == null)
//        {
//            throw new InvalidOperationException("Queue is empty");
//        }
//        return front.data;
//    }

//    public bool IsEmpty()
//    {
//        return front == null;
//    }
//}

//public class Program
//{
//    public static void Main()
//    {
//        Queue queue = new Queue();
//        queue.Enqueue(56);
//        queue.Enqueue(30);
//        queue.Enqueue(70);

//        Console.WriteLine(queue.Dequeue()); // prints 56
//        Console.WriteLine(queue.Dequeue()); // prints 30
//        Console.WriteLine(queue.Dequeue()); // prints 70
//    }
//}
