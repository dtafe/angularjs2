using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Shop.DomainModel.Entities
{
    public class CustomerCustomerDemoGraphics : BaseEntity
    {        
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
        
        public int CustomerTypeId { get; set; }
        public virtual CustomerDemoGraphic CustomerDemoGraphic { get; set; }

    }
}
