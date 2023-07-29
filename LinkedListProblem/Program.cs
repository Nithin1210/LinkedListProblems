using LinkedListProblem;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
     
          
            Console.WriteLine("!! Linked List Operation !!");
            LinkedList list = new LinkedList();
        
            list.AddInReverseOrder(52);
            list.AddInReverseOrder(30);
            list.AddInReverseOrder(75);

            list.Display();

        
    }
}