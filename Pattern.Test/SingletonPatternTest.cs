using Pattern.SingletonPattern;
using System;
using System.Threading;
using Xunit;

namespace Pattern.Test
{
    public class SingletonPatternTest
    {
        [Fact]
        public void Test()
        {
            Assert.Equal(1, Singleton<Job>.GetInstance().Get());
        }

        [Fact]
        public void TestMultiThread()
        {
            for (int i = 0; i < 2; i++)
            {
                var actual = -1;
                Thread th = new Thread(() =>
                {
                    actual = Singleton<Job>.GetInstance().Get();
                });
                th.Start();
                th.Join();

                Assert.Equal(1, actual);
            }
        }

        private class Job
        {
            private static int COUNT = 0;

            private Job()
            {
                COUNT += 1;
            }

            public int Get()
            {
                return COUNT;
            }
        }
    }
}
