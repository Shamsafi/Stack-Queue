using System;

public class Node
{
    public int data;
    public Node next;
    public Node(int d)
    {
        data = d;
        next = null;
    }
}

public class Queue
{
    public Node front, rear;
    public Queue()
    {
        front = rear = null;
    }
    public void Enqueue(int data)
    {
        Node newNode = new Node(data);
        if (rear == null)
        {
            front = rear = newNode;
        }
        else
        {
            rear.next = newNode;
            rear = newNode;
        }
    }
    public int Dequeue()
    {
        if (front == null)
        {
            Console.WriteLine("Queue is empty");
            return -1;
        }
        else
        {
            int data = front.data;
            front = front.next;
            if (front == null)
            {
                rear = null;
            }
            return data;
        }
    }
}

public class Program
{
    public static void Main()
    {
        Queue queue = new Queue();
        queue.Enqueue(56);
        queue.Enqueue(30);
        queue.Enqueue(70);
        Console.WriteLine("Elements in the queue:");
        //while (queue.front != null)
        //{
        //    Console.WriteLine("Dequeue: " + queue.Dequeue());
        //}
    }
}