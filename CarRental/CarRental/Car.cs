using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental
{
    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int RegNumber { get; set; }
        public bool Hired { get; set; }

        public Car()
        {
            Make = "Unkown";
            Model = "X";
            RegNumber = 0;
            Hired = false;
        }
    }
}
