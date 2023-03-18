namespace Iterator
{
    public interface Iterator <T>
    {
        bool hasNext();
        T ? next();
    }
}