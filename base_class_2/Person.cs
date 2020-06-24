using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _240620_
{
    abstract class PersonBase
    {
        public string _name;

        public override string ToString()
        {
            return $"[Person] Name : {_name} ... type: {base.ToString()}";
        }
    }
}
