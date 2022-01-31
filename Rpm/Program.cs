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

            Duck[] ducks = new Duck[] { malardDuck, redheadDuck, rubberDuck,decoyDuck  };

            for (int i = 0; i < ducks.Length; i++)
            {
                Console.WriteLine(ducks[i].swim());        
                Console.WriteLine(ducks[i].display());

                if (ducks[i] is Quackable)
                    Console.WriteLine((ducks[i] as Quackable).quack());

                if (ducks[i] is Flyable)
                    Console.WriteLine((ducks[i] as Flyable).fly());
            }

            

            Console.ReadKey();
        }
    }
}
