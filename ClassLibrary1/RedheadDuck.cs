using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class RedheadDuck : Duck
    {
        public RedheadDuck ()
        {
            flyBehavior = new FlyWithWings();
            quackBehavior = new Squeak();
        }
    }

}
