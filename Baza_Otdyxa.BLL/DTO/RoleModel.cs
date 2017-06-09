using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Baza_Otdyxa.BLL.DTO
{
    public class RoleModel
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public ICollection<IdentityUserRole> Users { get; set; }
    }
}
