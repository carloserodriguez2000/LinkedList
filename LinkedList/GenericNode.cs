using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class GenericNode<T>
    {
        private GenericNode<T> _NextNode = null;
        private T _Data;
        public GenericNode(T data)     //CONSTRUCTOR
        {
            _Data = data;
        }
        public T Data
        {
            get { return _Data; }
            set { _Data = value; }
        }

        
         public GenericNode<T> NextNode
        {
            get { return _NextNode; }
            set { _NextNode = value; }
        }
        

    }
}
