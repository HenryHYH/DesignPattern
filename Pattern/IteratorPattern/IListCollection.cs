namespace Pattern.IteratorPattern
{
    public interface IListCollection<T>
    {
        Iterator<T> GetIterator();
    }
}
