using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.DomainModel.Entities
{
    public class AppUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MidName { get; set; }
        public string TwitterId { get; set; }
        public string GoogleId { get; set; }
        public long? FacebookId { get; set; }
        public string PictureUrl { get; set; }
        public string Avatar { get; set; }
        
        public string State { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public string Address { get; set; }

        public int CountryId { get; set; }
        public virtual Country Country { get; set; }
    }
}
