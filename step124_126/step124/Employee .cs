﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step124
{
    class Employee : Person, IQuittable
    {
        public int id { get; set; }

        public static bool operator !=(Employee x, Employee y)
        {
            bool diff = x.id != y.id;
            return diff;
        }
        public static bool operator ==(Employee x, Employee y)
        
        {
            bool same = x.id == y.id;
            return same;
        }

        public void SayName2()
        {
            SayName();
        }

        public void Quit() 
        {
            throw new NotImplementedException();
        }
    }
}
