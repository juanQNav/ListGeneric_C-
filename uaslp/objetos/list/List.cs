using Iterator;

namespace ListG
{
    public interface ListG <T>
    {
    void addAtTail(T ? data);
    void addAtFront(T ? data);
    void remove(int index);
    void removeAll();
    void setAt(int index, T ? data);
    T ? getAt(int? index);
    void removeAllWithValue(T ? data);
    int getSize();
    Iterator <T> getIterator();
    }
}