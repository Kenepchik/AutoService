using System;
using System.Collections.Generic;

namespace AutoService.Models
{
    public partial class Orders
    {
        public int Id { get; set; }
        public int OrderNumber { get; set; }
        public double Cost { get; set; }
        public DateTime DateStart { get; set; }
        public int CustomersCarsId { get; set; }
        public string Status { get; set; }
        public string Description { get; set; }
        public DateTime DateEnd { get; set; }
        public int ClientServiceId { get; set; }

        public virtual ClientService ClientService { get; set; }
        public virtual Cars CustomersCars { get; set; }
    }
}
