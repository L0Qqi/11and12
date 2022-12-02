using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW11.Classes
{
    internal class Passive : Student
    {
        public Passive(string name, string numberOfGroup) : base(name, numberOfGroup) { PorA = "P"; }
        protected Passive(string name, int lastMer, string numberOfGroup) : base(name, lastMer, numberOfGroup) { }
    }
}
