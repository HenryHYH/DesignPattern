using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.AdapterPattern
{
    public class ObjectAdapter : IThreeHole
    {
        private readonly TwoHole twoHole = new TwoHole();

        public string GetPowerFromThreeHole()
        {
            return twoHole.GetPowerFromTwoHole();
        }
    }
}
