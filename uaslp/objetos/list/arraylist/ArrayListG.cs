using ListG;
using Iterator;
using ArrayListIterator;

namespace ArrayListG
{
    public class ArrayListG <T> : ListG <T> where T : class
    {
        private const int INITIAL_SIZE = 2;
        private T? []array;
        private int size; // cuántos datos se han insertado al arreglo

        public ArrayListG(){
            array = new T[INITIAL_SIZE];
        }

        public void addAtTail(T ? data){
            if(size == array.Length){
                increaseSize();
            }
            array[size] = data;
            size++;
        }
        public void addAtFront(T? data){
            if(size == array.Length){
                increaseSize();
            }
            if (size >= 1) {
                for (int i = size; i > 0; i--) {
                    array[i] = array[i - 1];
                }
            }
            array[0] = data;
            size++;
        }
        public void remove(int index){
            if(index <= size) {
                for(int i = index ; i < size; i++){
                    array[i] = array[i + 1];
                }
                size--;
            }else {
                Console.WriteLine("error: index not found");
            }
        }
        public void removeAll(){
            array = new T[INITIAL_SIZE];
            size= 0;
        }
        public void setAt(int index, T ? data){
            array[index] = data;
        }
        public T? getAt(int ? index){
            T? data = null;
            int indexIterator = 0;
            if(index <= size)
            {
                ArrayListIterator <T> iterator = (ArrayListIterator <T>) getIterator();
                while (iterator.hasNext() && indexIterator != index){
                    data = iterator.next();
                    indexIterator++;
                }
                return data;
            }else {
                Console.WriteLine("error: index not found");
                return null;
            }
        }
        public void removeAllWithValue(T ?data){
            int counterEliminations = 0;
        for(int i = 0; i < getSize(); i++){
            if(data==array[i-counterEliminations]){
                remove(i - counterEliminations);
                counterEliminations++;
            }
        }

        }
        public int getSize(){
            return size;
        }
        private void increaseSize(){
            T ? []newArray = new T[array.Length * 2];

            for(int i = 0; i < array.Length; i++){
                newArray[i] = array[i];
            }
            array = newArray;
        }
        public Iterator <T> getIterator() {
            return (Iterator<T>) new ArrayListIterator<T>(array);
        }
}
}