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
            passengers = generator.Next(1, 4);
            contrabandAmount = 0;
        }
    }
}
