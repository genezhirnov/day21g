using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project1.Controllers
{
    [ApiController]
    [Route("e2")]
    public class SampleController : Controller
    {
        [HttpGet("longRandom")]
        public Task<string> Index()
        {
            return performLongRunningOperationToGetRandomIntCSV();
        }

        private async Task<string> performLongRunningOperationToGetRandomIntCSV()
        {
            var rnd = new Random();
            int numberCount = rnd.Next(1, 10);
            List<Task<int>> taskList = new List<Task<int>>();
            for(var i = 0; i < numberCount; i++)
            {
                taskList.Add(Task.Factory.StartNew(() =>
                {
                    System.Threading.Thread.Sleep(rnd.Next(50, 8001));
                    return rnd.Next(1, 101);
                }));
            }
            await Task.WhenAll(taskList.ToArray());
            return String.Join(", ", 
                taskList.Select(x => x.Result));
        }
    }
}
