﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW12
{
    internal class PersonEvent
    {
        public PersonEvent(string m)
        {
            Message = m;
        }
        public string Message
        {
            get; set;
        }
    }
}
