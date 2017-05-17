namespace Pattern.IteratorPattern
{
    public interface Iterator<T>
    {
        bool MoveNext();

        T GetCurrent();

        void Next();

        void Reset();
    }
}
