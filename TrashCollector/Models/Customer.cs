using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TrashCollector.Models
{
    public class Customer
    {
            [Key]
            public int Id { get; set; }
            public string Name { get; set; }
            public string Address { get; set; }
            public string City { get; set; }
            public string State { get; set; }
            public string ZipCode { get; set; }
            public string DayOfTheWeek { get; set; }
            public DateTime StartDate { get; set; }
            public DateTime EndDate { get; set; }
            public int BalanceDue { get; set; }



            [ForeignKey("IdentityUser")]
            public string IdentityUserId { get; set; }
            public IdentityUser IdentityUser { get; set; }

        
        
    }
}
