 namespace Node
 {
     internal class Node <T> where T : class
    {
        internal  T ? data;
        internal Node <T> ? next;
        internal Node <T> ? previous;

        public Node(T ? data) {
            this.data = data;
            next = null;
            previous = null;
        }
        public void setData (T ? data){
            this.data = data;
        }
        public void setNext(Node <T>? next)
        {
            this.next = next;
        }
        public void setPrevious(Node <T>? previous)
        {
            this.previous = previous;
        }
    }
 }