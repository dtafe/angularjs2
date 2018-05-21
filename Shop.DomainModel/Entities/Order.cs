using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Shop.DomainModel.Entities
{
    public class Order : BaseEntity
    {        
        public DateTime OrderDate { get; set; }
        public DateTime RequiredDate { get; set; }
        public DateTime ShippedDate { get; set; }
        public int ShipVia { get; set; }
        public int Freight { get; set; }

        [StringLength(64)]
        public string ShipName { get; set; }

        [StringLength(256)]
        public string Address { get; set; }

        [StringLength(28)]
        public string City { get; set; }

        [StringLength(28)]
        public string Region { get; set; }

        [StringLength(8)]
        public string ZipCode { get; set; }

        public int CountryId { get; set; }
        public virtual Country Country { get; set; }

        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }

        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
