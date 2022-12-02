using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW11.Classes
{
    internal class Active : Student
    {
        public Active(string name, string numberOfGroup) : base(name, numberOfGroup) { PorA = "A"; }
        public Active(string name, int lastMer, string numberOfGroup) : base(name, lastMer, numberOfGroup) { }
    }
}
