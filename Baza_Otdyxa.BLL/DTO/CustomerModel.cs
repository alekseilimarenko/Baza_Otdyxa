using System;

namespace Baza_Otdyxa.BLL.DTO
{
    public class CustomerModel
    {
        public string Id { get; set; }

        public DateTime DateTimeCreate { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public string Address { get; set; }
    }
}
