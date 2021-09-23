using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project1
{
    public class FunnelCake

    {


        public int Quantity { get; set; }


        public bool Vomit => Quantity > 3 ? true : false;
    }




}
