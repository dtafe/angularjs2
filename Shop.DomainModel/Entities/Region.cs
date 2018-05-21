using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Shop.DomainModel.Entities
{
    public class Region : BaseEntity
    {
        [StringLength(64)]
        public string Description { get; set; }

        public ICollection<Territory> Territories { get; set; }
    }
}
