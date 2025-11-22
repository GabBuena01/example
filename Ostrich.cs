using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePrac
{
    public class Ostrich : Bird
    {
        public override void move()
        {
            Console.WriteLine("The ostrich is running ");
        }
    }
}
