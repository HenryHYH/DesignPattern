namespace Pattern.IteratorPattern
{
    internal class ConcreteIterator<T> : Iterator<T>
    {
        private ConcreteList<T> list;
        private int index;

        public ConcreteIterator(ConcreteList<T> list)
        {
            this.list = list;
            index = 0;
        }

        public T GetCurrent()
        {
            return list.GetElemnt(index);
        }

        public bool MoveNext()
        {
            return (index < list.Length);
        }

        public void Next()
        {
            if (index < list.Length)
                index++;
        }

        public void Reset()
        {
            index = 0;
        }
    }
}
