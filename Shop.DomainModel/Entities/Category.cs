using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.DomainModel.Entities
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Picture { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
