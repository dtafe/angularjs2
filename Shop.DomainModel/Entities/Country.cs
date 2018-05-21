using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Shop.DomainModel.Entities
{
    public class Country : BaseEntity
    {
        [StringLength(64)]
        public string Name { get; set; }
    }
}
