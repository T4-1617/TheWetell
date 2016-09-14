using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarCompany
{
    class Car
    {
        public string make { get; set; }
        public string model { get; set; }
        public int regNumber { get; set; }
        public string seats { get; set; }

        public Car()
        {
            make = "Unknown";
            model = "X";
            regNumber = 0;
            seats = "0";
        }
    }


}
