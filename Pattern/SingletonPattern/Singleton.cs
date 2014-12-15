using System;

namespace Pattern.SingletonPattern
{
    public class Singleton
    {
        private static Singleton instance;

        private static readonly object locker = new object();

        private Singleton()
        {
        }

        public static Singleton GetInstance()
        {
            if (null == instance)
                lock (locker)
                    if (null == instance)
                        instance = new Singleton();

            return instance;
        }
    }

    public class Singleton<T> where T : class
    {
        private static T instance;

        private static readonly object locker = new object();

        public static T GetInstance()
        {
            if (null == instance)
                lock (locker)
                    if (null == instance)
                        instance = (T)Activator.CreateInstance(typeof(T), true);

            return instance;
        }
    }
}
