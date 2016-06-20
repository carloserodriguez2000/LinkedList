using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class MyGenericLinkedList<T>
    {
        private GenericNode<T> Head = null;
        public MyGenericLinkedList()
        {
            Head = null;
        }
        //public void AddNode()
        //{
        //    GenericNode<T> aNode = new GenericNode<T>();
        //    LinkNode(aNode);
        //}
        //public void AddNode(GenericNode<T> aNode)
        //{
        //    LinkNode(aNode);
        //}
        public void AddNode(T data)
        {
            GenericNode<T> anode = new GenericNode<T> (data);
            LinkNode(anode);
        }
        private void LinkNode(GenericNode<T> aNode)
        {
            GenericNode<T> nodePointer;
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
            GenericNode<T> nodePointer = Head;

            do
            {
                // Console.WriteLine(nodePointer.FirstName + " " + nodePointer.LastName);
                Console.WriteLine(nodePointer.Data);
                nodePointer = nodePointer.NextNode;

            } while (nodePointer != null);
        }
        public System.Collections.Generic.IEnumerator<GenericNode<T>> GetEnumerator()
        {
            GenericNode<T> nodePointer = Head;
            do
            {
                yield return nodePointer;
                nodePointer = nodePointer.NextNode;
            } while (nodePointer != null);

        }
    }
}
