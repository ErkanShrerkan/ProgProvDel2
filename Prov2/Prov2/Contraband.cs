using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prov2
{
    class Contraband : Car
    {
        public Contraband()
        {
            passengers = generator.Next(1, 5); // lägst 1 och högst 4
            contrabandAmount = generator.Next(1, 5);
        }
    }
}
