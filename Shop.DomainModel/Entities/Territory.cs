using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Shop.DomainModel.Entities
{
    public class Territory : BaseEntity
    {
        [StringLength(128)]
        public string Description { get; set; }

        public int RegionId { get; set; }
        public virtual Region Region { get; set; }

        public ICollection<EmployeeTerritories> EmployeeTerritories { get; set; }
    }
}
