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
        public string Colour { get; set; }
        public int Seats { get; set; }
        public int Milage { get; set; }
        public bool Hired { get; set; }

        public Car()
        {
            Make = "Unkown";
            Model = "X";
            Hired = false;
        }
    }
}
