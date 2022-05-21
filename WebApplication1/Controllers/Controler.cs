using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Controler : ControllerBase
    {
        List<Car> car;
        [HttpGet("[action]")]
        public Car get(int id)
        {
            return
            car.FirstOrDefault(e => e.id == id);
        }
        [HttpPost("[action]")]
        public void Add(Car car)
        {
            car.Add(car);
        }



    }
}
