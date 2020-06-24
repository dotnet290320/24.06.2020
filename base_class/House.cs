using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _240620
{
    abstract class House
    {
        public string _address;

        public void PrintAddress()
        {
            Console.WriteLine($"Addres = {_address}");
        }

        public abstract double CalcHouseSize();

        public override string ToString()
        {
            return $"[House] address : {_address}";
        }
    }
}
