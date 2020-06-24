using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _240620
{
    class Program
    {
        static void Main(string[] args)
        {
            SquareHouse squareHouse = new SquareHouse()
            {
                _address = "Hertzrel 80 Tel aviv",
                _wallLength = 12
            };
            double sizeOfHouse = squareHouse.CalcHouseSize();
            Console.WriteLine(
                $"Square house size = {sizeOfHouse}");

            Console.WriteLine(squareHouse);

            SquareHouseWithGarden squareHouseWGarden = new SquareHouseWithGarden()
            {
                _address = "Hertzrel 80 Tel aviv",
                _wallLength = 12,
                _gardenSize = 50
            };
            Console.WriteLine(squareHouseWGarden);
        }
    }
}
