using System;

namespace Pattern.TemplateMethodPattern
{
    public class CustomerDataObject : DataObject
    {
        public override void Connect()
        {
            Console.WriteLine("Connect");
        }

        public override void Disconnect()
        {
            Console.WriteLine("Disconnect");
        }

        public override void Process()
        {
            Console.WriteLine("Process");
        }

        public override void Select()
        {
            Console.WriteLine("Select");
        }
    }
}
