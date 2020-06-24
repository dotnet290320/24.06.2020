using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _240620
{
    class SquareHouse : House
    {
       public double _wallLength;

        public override double CalcHouseSize()
        {
            return _wallLength * _wallLength;
        }

        public void PrintDetails()
        {
            string address = base._address;

            // 1 -- redundent, some benefits
            base.PrintAddress();
            // 2
            PrintAddress();

            // 3 -- recommended
            this.PrintAddress();
        }

        public override string ToString()
        {
            return $"[SquareHouse] wallLength : {_wallLength} size of house : {this.CalcHouseSize()} {base.ToString()}";
        }
    }
}
