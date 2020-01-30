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
            passengers = generator.Next(1, 5);
            contrabandAmount = generator.Next(1, 5);
        }
    }
}
