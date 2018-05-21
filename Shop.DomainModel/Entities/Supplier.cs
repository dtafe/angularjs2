using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Shop.DomainModel.Entities
{
    public class Supplier : BaseEntity
    {
        [StringLength(64)]
        public string CompanyName { get; set; }

        [StringLength(64)]
        public string ContactName { get; set; }

        [StringLength(256)]
        public string ContactTitle { get; set; }

        [StringLength(256)]
        public string Address { get; set; }

        [StringLength(28)]
        public string City { get; set; }

        [StringLength(28)]
        public string Region { get; set; }

        [StringLength(8)]
        public string ZipCode { get; set; }

        public int Country { get; set; }

        [StringLength(16)]
        public string Phone { get; set; }

        [StringLength(16)]
        public string Fax { get; set; }

        [StringLength(64)]
        public string HomePage { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
