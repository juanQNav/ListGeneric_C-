using Iterator;

namespace ArrayListIterator
{
    public class ArrayListIterator<T> : Iterator<T> where T: class{
    T? []array;
    int currentIndex;
    public ArrayListIterator(T? []array){
        this.array = array;
        currentIndex = 0;
    }
    public bool hasNext(){return array[currentIndex] != null;}
    public T? next(){
        T?  data = array[currentIndex];
        currentIndex++;
        return data;
    }
}
}