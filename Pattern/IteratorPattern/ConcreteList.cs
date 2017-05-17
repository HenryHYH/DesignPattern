namespace Pattern.IteratorPattern
{
    public class ConcreteList<T> : IListCollection<T>
    {
        private T[] collection;

        public ConcreteList(T[] collection)
        {
            this.collection = collection;
        }

        public Iterator<T> GetIterator()
        {
            return new ConcreteIterator<T>(this);
        }

        public int Length
        {
            get { return collection.Length; }
        }

        public T GetElemnt(int index)
        {
            return collection[index];
        }
    }
}
