using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FunnelCakeController : ControllerBase
    {

        //https://localhost:44395/funnelcake/get
        //^that is the path

        [HttpGet("[action]")]
        public FunnelCake Get()
        {
            return new FunnelCake()
            {
                Quantity = new Random().Next(6)
            };

        }

       

    }
}
