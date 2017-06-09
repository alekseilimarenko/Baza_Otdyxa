using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Baza_Otdyxa.DAL.Entities
{
    public class CustomerCatalog
    {
        [Key]
        public Guid CustomerId { get; set; }

        public DateTime DateTimeCreate { get; set; }

        [Required]
        [MaxLength(50)]
        public string FirstName  { get; set; }
        
        public string LastName { get; set; }

        [Required]
        [MaxLength(15)]
        public string Phone { get; set; }

        [Required]
        [MaxLength(20)]
        public string Email { get; set; }

        [Required]
        [MaxLength(255)]
        public string Address { get; set; }

        public virtual ICollection<OrderCatalog> OrderCatalog { get; set; }
    }
}
