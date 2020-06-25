using System;
using System.Collections.Generic;

namespace AutoService.Models
{
    public partial class CustomersCars
    {
        public int Id { get; set; }
        public int CarsId { get; set; }
        public int ClientsId { get; set; }
        public string Color { get; set; }
        public string LicensePlate { get; set; }
        public int YearIssue { get; set; }
        public double Mileage { get; set; }
        public double Vin { get; set; }

        public virtual Cars Cars { get; set; }
        public virtual Clients Clients { get; set; }
    }
}
