using Microsoft.AspNetCore.Identity;

namespace VetClinic_Server.Data.Models
{
    public class AppUser : IdentityUser
    {
        public Vet Vet { get; set; } = new Vet();
    }
}
