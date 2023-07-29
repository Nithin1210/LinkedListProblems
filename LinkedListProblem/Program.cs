using LinkedListProblem;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
     
          
            Console.WriteLine("!! Linked List Operation !!");
            LinkedList list = new LinkedList();

        list.Add(22);
        list.Add(33);
        list.Add(44);
      
        list.InserAtParticularPosition(2, 40);
        list.RemoveFirstNode();
        list.RemoveLastNode();

        list.Display();


    }
}