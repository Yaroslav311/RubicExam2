using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    public class Car
    {
        public int id { get; set; }
        public String image { get; set; }
        public int price { get; set; }
        public String brand { get; set; }
        public String model { get; set; }
        public String co2 { get; set; }
        public String fuelCons { get; set; }

        internal void Add(Car car)
        {
            throw new NotImplementedException();
        }
    };
}
