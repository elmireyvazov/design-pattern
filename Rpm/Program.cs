using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace Rpm
{
    class Program
    {
        static void Main(string[] args)
        {
            MalardDuck malardDuck = new MalardDuck();
            RedheadDuck redheadDuck = new RedheadDuck();
            RubberDuck rubberDuck = new RubberDuck();
            DecoyDuck decoyDuck = new DecoyDuck();

            FlyBehavior flyNoWay = new FlyNoWay();
            QuackBehavior  muteQuack = new MuteQuack();

            malardDuck.setFlyBehavior(flyNoWay);
            malardDuck.setQuackBehavior (muteQuack);

            Duck[] ducks = new Duck[] { malardDuck, redheadDuck, rubberDuck,decoyDuck  };

            for (int i = 0; i < ducks.Length; i++)
            {
                Console.WriteLine(ducks[i].swim());        
                Console.WriteLine(ducks[i].display());
                Console.WriteLine(ducks[i].fly());
                Console.WriteLine(ducks[i].quack());

            }
            Console.ReadKey();
        }
    }
}
