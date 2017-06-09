using Microsoft.AspNet.Identity.EntityFramework;

namespace Baza_Otdyxa.DAL.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public virtual ClientProfile ClientProfile { get; set; }
    }
}
