using System;

namespace Pattern.FlyweightPattern
{
    public class Flavor : Order
    {
        private string flavor;

        public Flavor(string flavor)
        {
            this.flavor = flavor;
        }

        public override string GetFlavor()
        {
            return flavor;
        }

        public override void Serve(Table table)
        {
            Console.WriteLine("Serving table {0} with flavor {1}", table.Number, flavor);
        }
    }
}
