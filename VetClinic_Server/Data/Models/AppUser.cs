using Microsoft.AspNetCore.Identity;

namespace VetClinic_Server.Data.Models
{
    public class AppUser : IdentityUser
    {
        public Vet? Vet { get; set; } = null;
        public Owner? Owner { get; set; } = null;
    }
}
