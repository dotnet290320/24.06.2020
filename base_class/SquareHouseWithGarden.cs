using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _240620
{
    class SquareHouseWithGarden : SquareHouse
    {
        public double _gardenSize;

        public override double CalcHouseSize()
        {
            // bad practice
            // return _wallLength * _wallLength + _gardenSize;

            // this._wallLength -- the same -- base._wallLength
            double papa_calc = base.CalcHouseSize();
            double total_size = papa_calc + _gardenSize;

            return total_size;
        }

        public override string ToString()
        {
            return $"[House with Garden] : gardenSize : {_gardenSize} {base.ToString()}";
        }
    }
}
