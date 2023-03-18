using Iterator;
using Node;

namespace LinkedListIterator
{
    public class LinkedListIterator <T> : Iterator <T> where T:class
    {
        internal Node <T> ? currentNode;
        internal LinkedListIterator(Node <T> ? head){
            currentNode = head;
        }
        public bool hasNext(){
            return currentNode != null;
        }
        public T ? next(){
            T? data = currentNode?.data;
            currentNode = currentNode?.next;
            return  data;
        }
    }
}