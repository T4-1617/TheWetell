using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarCompany
{
    class Car
    {
        Random r = new Random();
        public int RegNumber()
        {
            int plate = r.Next(100, 500);
            return plate;
        }
        public string Type { get; set; }
        public int Seats { get; set; }
        public int Volume { get; set; }
    }
}
