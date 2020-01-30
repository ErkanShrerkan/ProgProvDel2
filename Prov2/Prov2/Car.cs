using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prov2
{
    class Car
    {
        public int passengers;
        public int contrabandAmount;
        public bool alreadyChecked;
        public Random generator = new Random();

        public bool Examine()
        {
            // inte garanterat att hitta stöldgodset men chansen ökar med mängden och 0 om bilen är ren
            if (generator.Next(0, 100) * contrabandAmount > 60) 
            {
                return true;
            }
            else return false;
        }
    }
}
