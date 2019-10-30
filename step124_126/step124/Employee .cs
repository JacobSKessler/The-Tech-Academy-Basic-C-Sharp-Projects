using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step124
{
    class Employee : Person, IQuittable
    {
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
