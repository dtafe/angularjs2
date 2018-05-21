using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Shop.DomainModel.Entities
{
    public class Customer : BaseEntity
    {
        public string IdentityId { get; set; }
        public virtual AppUser Identity { get; set; }  // navigation property

        [StringLength(28)]
        public string Location { get; set; }

        [StringLength(28)]
        public string Locale { get; set; }

        public GenderEnumType Gender { get; set; }

        public ICollection<Order> Orders { get; set; }
    }

    public enum GenderEnumType
    {
        [Description("Other")]
        Other = 0,
        [Description("Male")]
        Male = 1,
        [Description("Female")]
        Female = 2,        
    }
}
