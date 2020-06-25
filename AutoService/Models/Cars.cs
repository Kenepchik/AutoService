using System;
using System.Collections.Generic;

namespace AutoService.Models
{
    public partial class Cars
    {
        public Cars()
        {
            CustomersCars = new HashSet<CustomersCars>();
            Orders = new HashSet<Orders>();
        }

        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }

        public virtual ICollection<CustomersCars> CustomersCars { get; set; }
        public virtual ICollection<Orders> Orders { get; set; }
    }
}
