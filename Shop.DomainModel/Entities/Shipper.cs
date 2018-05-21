using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Shop.DomainModel.Entities
{
    public class Shipper : BaseEntity
    {
        [StringLength(64)]
        public string CompanyName { get; set; }

        [StringLength(16)]
        public string Phone { get; set; }
    }
}
