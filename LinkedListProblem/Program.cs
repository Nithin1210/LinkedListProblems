using LinkedListProblem;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Here is Queue Fuction");
        LinkedListQueue queue = new LinkedListQueue();
        queue.Enqueue(56);
        queue.Enqueue(30);
        queue.Enqueue(70);
        queue.Display();
        queue.Dequeue();
        queue.Display();


    }
}