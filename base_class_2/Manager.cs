using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _240620_
{
    class Manager : Employee
    {
        public string _division;

        public override string ToString()
        {
            return $"[Manager] Division : {_division} {base.ToString()} ";
        }
    }

}
