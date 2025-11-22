using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePrac
{
    public class BirdMain
    {
        public static void Main(string[] args)
        {
            Bird myEagle = new Eagle();
            myEagle.move();
            myEagle.eat();
            Bird myOstrich = new Ostrich();
            myOstrich.move();
            myOstrich.eat();
        }
    }
}
