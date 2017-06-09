using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Baza_Otdyxa.DAL.Entities
{
    public class RoomFotoCatalog
    {
        [Key]
        public Guid FotoId { get; set; }

        [ForeignKey("RoomId")]
        public Guid RoomId { get; set; }

        public string FilePath { get; set; }

        public virtual RoomCatalog RoomCatalog { get; set; }
    }
}
