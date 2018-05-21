using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Shop.DomainModel.Entities
{
    public class CustomerDemoGraphic : BaseEntity
    {
        [StringLength(128)]
        public string Description { get; set; }

        public ICollection<CustomerCustomerDemoGraphics> CustomerCustomerDemoGraphics { get; set; }
    }
}
