using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePrac
{
    public abstract class Bird
    {
        public abstract void move();
        public void eat()
        {
            Console.WriteLine("The bird is eating ");
        }
    }
}
