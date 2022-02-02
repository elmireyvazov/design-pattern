using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class MalardDuck : Duck
    {
        public override string display()
        {
            return "display" + this.GetType();
        }
        public string fly()
        {
            return "fly";
        }
        public string quack()
        {
            return "quack";
        }
        public MalardDuck 
            { }
         
    }
}


