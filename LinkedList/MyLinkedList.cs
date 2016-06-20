using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{

    class MyLinkedList
    {
        private Node Head = null;
        public MyLinkedList()
        {
            Head = null;
        }
        public Node AddNode()
        {

            Node aNode = new Node();
            LinkNode(aNode);
            return aNode;
        }
        public void AddNode(Node aNode)
        {
            LinkNode(aNode);
        }
        private void LinkNode(Node aNode)
        {
            Node nodePointer;
            if (Head == null)
            {
                Head = aNode; // First time have head point to new item               Head = aNode;
                return;
            }

            nodePointer = Head;
            while (nodePointer.NextNode != null) // FIND THE END OF THE LIST
            {
                nodePointer = nodePointer.NextNode;
            }
            nodePointer.NextNode = aNode;       // APPEND NEW NODE TO THE END OF THE LIST
        }

        public void showList()
        {
            Node nodePointer = Head;

            do
            {
                Console.WriteLine(nodePointer.FirstName + " " + nodePointer.LastName);
                nodePointer = nodePointer.NextNode;

            } while (nodePointer != null);
        }
        public System.Collections.Generic.IEnumerator<Node> GetEnumerator()
        {
            Node nodePointer = Head;
            do
            {
                yield return nodePointer;
                nodePointer = nodePointer.NextNode;
            } while (nodePointer != null);

        }
    }
}
