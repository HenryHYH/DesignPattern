using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.AdapterPattern
{
    public class ClassAdapter : TwoHole, IThreeHole
    {
        public string GetPowerFromThreeHole()
        {
            return this.GetPowerFromTwoHole();
        }
    }
}
