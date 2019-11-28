using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step162
{
    class Class1
    {   //when I did the method() : this(stuff) style like used in almost every place I could find including the LMS videos the : was listing as an error I can not figure out why for the life of me
        private int id;

        public Class1() : this(id:0)
        {
            
        }

        public Class1(int id)
        {
            this.id = id;
        }



    }
}
