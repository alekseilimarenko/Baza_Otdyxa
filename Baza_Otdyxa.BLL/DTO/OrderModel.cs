using System;

namespace Baza_Otdyxa.BLL.DTO
{
    public class OrderModel
    {
        public string OrderId { get; set; }

        public DateTime DateTimeCreate { get; set; }

        public int OrderNumber { get; set; }

        public string RoomId { get; set; }

        public string CustomerId { get; set; }

        public string FistName { get; set; }

        public string LastName { get; set; }

        public string Phone { get; set; }

        public string Month { get; set; }

        public string ReservationDates { get; set; }

        public int PersonCount { get; set; }

        public int Price { get; set; }
    }
}