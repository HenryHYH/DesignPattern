using System;

namespace Pattern.TemplateMethodPattern
{
    public abstract class DataObject
    {
        public abstract void Connect();

        public abstract void Select();

        public abstract void Process();

        public abstract void Disconnect();

        public void Run()
        {
            Console.WriteLine("开始");

            Connect();
            Select();
            Process();
            Disconnect();

            Console.WriteLine("结束");
        }
    }
}
