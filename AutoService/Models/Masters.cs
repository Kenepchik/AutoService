using System;
using System.Collections.Generic;

namespace AutoService.Models
{
    public partial class Masters
    {
        public Masters()
        {
            Services = new HashSet<Services>();
        }

        public int Id { get; set; }
        public string Fio { get; set; }
        public string Specialization { get; set; }
        public string Address { get; set; }
        public string Telephone { get; set; }
        public int Seniority { get; set; }

        public virtual ICollection<Services> Services { get; set; }
    }
}
