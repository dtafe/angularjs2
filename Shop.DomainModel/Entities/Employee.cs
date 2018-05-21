using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Shop.DomainModel.Entities
{
    public class Employee : BaseEntity
    {
        [StringLength(64)]
        public string LastName { get; set; }

        [StringLength(64)]
        public string FirstName { get; set; }

        [StringLength(128)]
        public string Title { get; set; }

        [StringLength(256)]
        public string TitleOfCourtesy { get; set; }

        public DateTime BirthDate { get; set; }
        public DateTime HireDate { get; set; }

        [StringLength(256)]
        public string Address { get; set; }

        [StringLength(28)]
        public string City { get; set; }

        [StringLength(28)]
        public string Region { get; set; }

        [StringLength(8)]
        public string PostCode { get; set; }

        public string Country { get; set; }

        [StringLength(16)]
        public string HomePhone { get; set; }

        [StringLength(8)]
        public string Extension { get; set; }

        [StringLength(int.MaxValue)]
        public string Photo { get; set; }

        [StringLength(1024)]
        public string Notes { get; set; }

        [StringLength(64)]
        public string ReportsTo { get; set; }

        [StringLength(256)]
        public string PhotoPath { get; set; }

        public decimal Salary { get; set; }

        public ICollection<EmployeeTerritories> EmployeeTerritories { get; set; }
    }
}
