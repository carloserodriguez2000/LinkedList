using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
  
    class Node
    {
        private Node _NextNode = null;
        private string _FirstName;
        private string _LastName;

        public  Node()
        {
            // CONSTRUCTOR
        }
        public Node NextNode
        {
            get { return _NextNode; }
            set { _NextNode = value; }
        }
        public string FirstName
        {
            get { return _FirstName; }
            set { _FirstName = value; }
        }

        public string LastName
        {
            get { return _LastName; }
            set { _LastName = value; }
        }


    }
}
 //public string FirstName { get; set; }
