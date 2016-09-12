using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo120916
{
    class Program
    {
        static void Main(string[] args)
        {
            Car a = new Car();
            a.Colour = "Blue";
            Console.WriteLine(a.Colour);
        }
    }

    public class Car
    {
        public string RegNumber { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Colour { get; set; }
    }
}
