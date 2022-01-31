﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class RedheadDuck : Duck, Flyable, Quackable
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
    }

}
