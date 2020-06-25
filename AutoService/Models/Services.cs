using System;
using System.Collections.Generic;

namespace AutoService.Models
{
    public partial class Services
    {
        public Services()
        {
            ClientService = new HashSet<ClientService>();
        }

        public int Id { get; set; }
        public int MastersId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Complexity { get; set; }
        public double Price { get; set; }
        public int Guarantee { get; set; }

        public virtual Masters Masters { get; set; }
        public virtual ICollection<ClientService> ClientService { get; set; }
    }
}
