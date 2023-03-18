using ListG;
using Node;
using Iterator;
using LinkedListIterator;

namespace LinkedListG
{
    public class LinkedListG <T> : ListG <T> where T: class
    {
        private Node <T> ? head;
        private Node <T> ? tail;
        private int size;

        public LinkedListG(){
            head = null;
            tail = null;
            size = 0;
        }
        public void addAtTail(T ? data){
            Node <T> node = new Node <T> (data);
            Node <T> pointer;
            if(tail != null){
                pointer = tail;
                pointer.next = node;
                node.previous = pointer;
                tail = node;
            }else {
                tail = node;
                head = node;
            }
            size++;
        }
        public void addAtFront(T ? data){
            Node <T> node = new Node<T>(data);
            Node <T> pointer;

            if(head != null){
                pointer = head;
                pointer.previous = node;
                node.next = head;
                head = node;
            }else{
                head = node;
                tail = node;
            }
            size++;
        }
        public void remove(int index){
            Node <T> ? next;
            Node <T> ? previous;
            if(head != null) {
                int indexIterator = 0;
                LinkedListIterator <T> iterator = (LinkedListIterator <T>) getIterator();
                while (iterator.hasNext() && indexIterator != index){
                    iterator.next();
                    indexIterator++;
                }
                if(index < size && index == indexIterator) {
                    next = iterator.currentNode?.next;
                    previous = iterator.currentNode?.previous;
                    if (size == 1) {
                        head = null;
                        tail = null;
                    } else if (index > 0) {
                        if (index == size) {
                            previous = next;
                            tail = previous;
                        } else {
                            next?.setPrevious(previous);
                            previous?.setNext(next);
                        }
                    } else {
                        next?.setPrevious(previous);
                        head = next;
                    }
                    size--;
                }else {
                    Console.WriteLine("error: index not found");
                }
            }else {
                Console.WriteLine("error: list is empty");
            }
        }
        public void removeAll()
        {
            if(head != null){
                head = null;
                tail = null;
                size = 0;
            }else{
                Console.WriteLine("error: list is empty");
            }
        }
        public void setAt(int index, T ? data){
            if(head != null) {
                LinkedListIterator <T> ? iterator = (LinkedListIterator <T>) getIterator();
                int indexIterator = 0;
                while (iterator.hasNext() && indexIterator != index) {
                    iterator.next();
                    indexIterator++;
                }
                if(indexIterator == index)
                {
                    iterator.currentNode?.setData(data);
                }else{
                    Console.WriteLine("error: index not found");
                }
            }else{
                Console.WriteLine("error: list is empty");
            }
        }
        public T ? getAt(int? index){
            T ? data;
            if(head == null) {
                Console.WriteLine("error: list is empty");
                return default(T);
            }
            else{
                int indexIterator = 0;
                LinkedListIterator <T> iterator = (LinkedListIterator <T>) getIterator();
                data = iterator.next();
                while (iterator.hasNext() && indexIterator != index){
                    data = iterator.next();
                    indexIterator++;
                }
                if(index == indexIterator){
                    return data;
                }else {
                    Console.WriteLine("error: index not found");
                    return default(T);
                }
            }
        }
        public void removeAllWithValue(T ? data){
            if(head != null) {
                Iterator <T> iterator = getIterator();
                int indexIterator = 0;
                int eliminationCounter = 0;
                while (iterator.hasNext()) {
                    if (data == iterator.next()) {
                        remove(indexIterator-eliminationCounter);
                        eliminationCounter++;
                    }
                    indexIterator++;
                }
            }else{
                Console.WriteLine("error: list is empty");
            }
        }
        public int getSize(){
            return size;
        }
        public Iterator <T> getIterator(){
            return new LinkedListIterator<T>(head);
        }
    }
}