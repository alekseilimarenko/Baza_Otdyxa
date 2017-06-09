using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Baza_Otdyxa.DAL.Entities
{
    public class RoomCatalog
    {
        [Key]
        public Guid RoomId { get; set; }
        public string HouseNumber { get; set; }
        public string CategoryName { get; set; }
        public string RoomNumber { get; set; }
        public string Filial { get; set; }
        public string PriceWorkerHightSeason { get; set; }
        public string PriceWorkerLowSeason { get; set; }
        public string PriceAliensHightSeason { get; set; }
        public string PriceAliensLowSeason { get; set; }

        public virtual ICollection<OrderCatalog> Order { get; set; }
        public virtual ICollection<RoomFotoCatalog> RoomFoto { get; set; }
    }
}
