using System;
using System.Collections.Generic;

namespace AutoService.Models
{
    public partial class Clients
    {
        public Clients()
        {
            ClientService = new HashSet<ClientService>();
            CustomersCars = new HashSet<CustomersCars>();
        }

        public int Id { get; set; }
        public string Fio { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }

        public virtual ICollection<ClientService> ClientService { get; set; }
        public virtual ICollection<CustomersCars> CustomersCars { get; set; }
    }
}
