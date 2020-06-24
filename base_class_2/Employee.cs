using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _240620_
{
    class Employee : PersonBase
    {
        public int _hoursPerMonth;
        public double _hourRate;

        public double CalcSalary()
        {
            return _hoursPerMonth * _hourRate;
        }

            public override string ToString()
            {
                return $"[Employee] HoursPerMonth : {_hoursPerMonth} HourRate : {_hourRate} " +
                    $"salary : {CalcSalary()} {base.ToString()}";
            }
        }
}
