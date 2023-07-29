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
      

        int num = list.Search(33);
        Console.WriteLine("Position found in :" + num);
        list.DeleteNodeAtParticularPosition(1);

        list.Display();


    }
}