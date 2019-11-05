using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step162
{
    class Class1
    {
        private int id;
        private string name;

        public void Tag() : this(0, "") { }
        public void Tag(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
}
