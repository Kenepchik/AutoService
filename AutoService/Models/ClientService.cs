using System;
using System.Collections.Generic;

namespace AutoService.Models
{
    public partial class ClientService
    {
        public ClientService()
        {
            Orders = new HashSet<Orders>();
        }

        public int Id { get; set; }
        public int ServiceId { get; set; }
        public int ClientId { get; set; }
        public int Count { get; set; }
        public double Cost { get; set; }

        public virtual Clients Client { get; set; }
        public virtual Services Service { get; set; }
        public virtual ICollection<Orders> Orders { get; set; }
    }
}
