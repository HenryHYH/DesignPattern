using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.FactoryMethodPattern
{
    public class Game : Product
    {

        public override string Name
        {
            get { return "Game"; }
        }
    }
}
