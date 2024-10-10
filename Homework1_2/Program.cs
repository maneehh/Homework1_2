using System;
using System.Collections.Generic;

class CustomQueue<T>
{
    private List<T> queueList = new List<T>();

    public void Enqueue(T item)
    {
        queueList.Add(item);
        Console.WriteLine($"{item} added to the queue");
    }

    public T Dequeue()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("Queue is empty");
        }

        T value = queueList[0]; 
        queueList.RemoveAt(0); 
        Console.WriteLine($"{value} removed from the queue");
        return value;
    }

    public T Peek()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("Queue is empty");
        }

        return queueList[0];
    }

    public bool IsEmpty()
    {
        return queueList.Count == 0;
    }

    public void DisplayQueue()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Queue is empty");
        }
        else
        {
            Console.WriteLine("Queue contents:");
            foreach (var item in queueList)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        CustomQueue<int> queue = new CustomQueue<int>();

        queue.Enqueue(10);
        queue.Enqueue(20);
        queue.Enqueue(30);

        queue.DisplayQueue();

        Console.WriteLine($"Peek: {queue.Peek()}");

        queue.Dequeue();
        queue.DisplayQueue();

        Console.WriteLine($"Is the queue empty? {queue.IsEmpty()}");
    }
}
