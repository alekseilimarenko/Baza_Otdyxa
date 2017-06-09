using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Baza_Otdyxa.DAL.Entities
{
    public class OrderCatalog
    {
        [Key]
        public Guid OrderId { get; set; }

        public DateTime DateTimeCreate { get; set; }

        public int OrderNumber { get; set; }

        [ForeignKey("RoomId")]
        public Guid RoomId { get; set; }

        [ForeignKey("CustomerId")]
        public Guid CustomerId { get; set; }

        [Required]
        [MaxLength(50)]
        public string FistName { get; set; }

        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }

        [Required]
        [MaxLength(20)]
        public string Phone { get; set; }

        [Required]
        [MaxLength(12)]
        public string Month { get; set; }

        [Required]
        public string ReservationDates { get; set; }

        [Required]
        [MaxLength(3)]
        public int PersonCount { get; set; }

        public int Price { get; set; }

        public virtual RoomCatalog RoomCatalog { get; set; }
        public virtual CustomerCatalog CustomerCatalog { get; set; }
    }
}
