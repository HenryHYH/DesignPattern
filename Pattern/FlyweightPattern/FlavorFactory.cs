using System.Collections.Generic;

namespace Pattern.FlyweightPattern
{
    public class FlavorFactory
    {
        private IDictionary<string, Order> flavors = new Dictionary<string, Order>();

        public Order GetOrder(string key)
        {
            if (!flavors.TryGetValue(key, out Order flavor))
            {
                flavor = new Flavor(key);
                flavors.Add(key, flavor);
            }

            return flavor;
        }

        public int GetTotalFlavors()
        {
            return flavors.Count;
        }
    }
}
