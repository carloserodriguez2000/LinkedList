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

            /////////////////////////////////////////////////////////////////////////
            MyGenericLinkedList<string> aLinkedList = new MyGenericLinkedList<string>();
            aLinkedList.AddNode("Happy");
            aLinkedList.AddNode("Sad");
            aLinkedList.AddNode("Crying");
                    /////// Show string list  ////////////////////////////
            Console.WriteLine("Show string list ");
            foreach (var nodePointer in aLinkedList)
            {
                Console.WriteLine(nodePointer.Data);
            }
            /////////////////////////////////////////////////////////////////////////


           Console.ReadLine();


            /////////////////////////////////////////////////////////////////////////
            MyGenericLinkedList<int>  iLinkedList = new MyGenericLinkedList<int>();
            iLinkedList.AddNode(41);
            iLinkedList.AddNode(22);
            iLinkedList.AddNode(25);
            iLinkedList.AddNode(12);
            iLinkedList.AddNode(4);
            iLinkedList.AddNode(7);
                    ///////// Show INT list using an iterator ////////////////////////////
            Console.WriteLine("Show int list");
            foreach (var nodePointer in iLinkedList)
            {
                Console.WriteLine(nodePointer.Data);
            }
            /////////////////////////////////////////////////////////////////////////

            Console.ReadLine();
        }
    }
}
