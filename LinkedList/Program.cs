using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            MyLinkedList aLinkedList = new MyLinkedList();
            aLinkedList.AddNode(new Node() { FirstName = "Carlos", LastName = "Rodriguez" });
            Node aNode = new Node();
            aNode.LastName = "Tang";
            aNode.FirstName = "Jason";
            aLinkedList.AddNode(aNode);

            aLinkedList.AddNode(new Node() { FirstName = "Andree", LastName = "Kutzmichef" });
            aLinkedList.AddNode(new Node() { FirstName = "Kacey", LastName = "Hipp" });

            ////////////////  show list using a discreet loop //////////////////////
            Console.WriteLine("show list using a discreet loop");
            aLinkedList.showList();
            ///////////////////////////////////////////////////////////////////////

            Console.WriteLine();

            ////////////// Show list using an iterator ////////////////////////////
            Console.WriteLine("Show list using an iterator");
            foreach (Node nodePointer in aLinkedList)
            {
                Console.WriteLine(nodePointer.FirstName + " " + nodePointer.LastName);
            }
            ///////////////////////////////////////////////////////////////////////

            Console.Read();


        }
    }
}
