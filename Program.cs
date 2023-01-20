using System.Collections.Generic;

namespace DataStructuresdemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            Linkedlist list = new Linkedlist();
            list.Add(56);
            list.Add(30);
            list.Add(70);
            list.InsertAtParticularPosition(2, 51);
            list.RemoveFirstNode();
            list.Search(51);
            list.RemoveLastNode();
            list.Display();
        }
    }
}