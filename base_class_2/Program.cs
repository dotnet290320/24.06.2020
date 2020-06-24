using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _240620_
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager bigManager = new Manager()
            {
                _division = "Intel",
                _hourRate = 300,
                _hoursPerMonth = 220,
                _name = "Menny the manager"
            };

            Employee e = new Employee()
            {
                _name = "Gili",
                _hoursPerMonth = 200,
                _hourRate = 100
            };

            Console.WriteLine(bigManager);
            Console.WriteLine();
            Console.WriteLine(e);
        }
    }
}
