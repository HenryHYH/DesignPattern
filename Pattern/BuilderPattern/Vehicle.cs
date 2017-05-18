using System;

namespace Pattern.BuilderPattern
{
    public class Vehicle
    {
        private string type;

        public Vehicle(string type)
        {
            this.type = type;
        }

        public string Frame { get; set; }

        public string Engine { get; set; }

        public string Wheels { get; set; }

        public string Doors { get; set; }

        public void Show()
        {
            Console.WriteLine("Vehicle type:{0}", type);
            Console.WriteLine(" Frame:{0}", Frame);
            Console.WriteLine(" Engine:{0}", Engine);
            Console.WriteLine(" Wheels:{0}", Wheels);
            Console.WriteLine(" Doors:{0}", Doors);
        }
    }
}
