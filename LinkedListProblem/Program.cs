﻿using LinkedListProblem;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("LinkedList Problem");
        Console.WriteLine("Welcome to the Linked List Stack");
        LinkedListStack stack = new LinkedListStack();
        stack.Push(56);
        stack.Push(30);
        stack.Push(70);
        stack.Display();
        stack.Peek();
        stack.Pop();
        stack.Display();

    }
}