using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Shop.DomainModel.Entities
{
    public class EmployeeTerritories : BaseEntity
    {
        public int EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }

        public int TerritoryId { get; set; }
        public virtual Territory Territory { get; set; }
    }
}
