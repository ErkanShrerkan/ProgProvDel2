using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prov2
{
    class Clean : Car
    {
        public Clean()
        {
            passengers = generator.Next(1, 4); // slumpar mellan 1 och 4 (lägsta 1 och högsta blir 3)
            contrabandAmount = 0;
        }
    }
}
