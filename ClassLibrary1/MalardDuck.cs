using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class MalardDuck : Duck
    {
        public MalardDuck ()
        {
            flyBehavior = new FlyWithWings();
            quackBehavior = new Squeak();

        }
         
    }
}


