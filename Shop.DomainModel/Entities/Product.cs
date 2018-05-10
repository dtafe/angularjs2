using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.DomainModel.Entities
{
    public class Product : BaseEntity
    {                
        public string Name { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
        public int UnitsOnOrder { get; set; }
        public int ReorderLevel { get; set; }
        public bool Discontinued { get; set; }

        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

        public int SupplierId { get; set; }
        public virtual Supplier Supplier { get; set; }

        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
