using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public abstract class Duck
    {
        FlyBehavior flyBehavior;
        QuackBehavior quackBehavior;

        public string swim()
        {
            return "Буль буль буль";
        }
        public  string display()
        {
            return GetType() + "" + flyBehavior.GetType() + "" + quackBehavior.GetType(); 
        }

        public string fly()
        {
            return flyBehavior.fly();
        }
        public string quack()
        {
            return quackBehavior.quack();
        }
        public void setFlyBehavior(FlyBehavior f)
        {
            flyBehavior = f;
        }
        public void setQuackBehavior(QuackBehavior q)
        {
            quackBehavior = q;
        }
    }
}
