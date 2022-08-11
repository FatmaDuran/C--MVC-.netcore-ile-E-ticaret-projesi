using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eshop.WebUI.Entity
{
    public class Order
    {
      public int OrderId { get; set; }

        public string OrderName { get; set; }

        public double Total { get; set; }

        public DateTime OrderDate { get; set; }

    }
}
