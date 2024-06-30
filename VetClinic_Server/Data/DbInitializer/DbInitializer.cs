using Microsoft.AspNetCore.Identity;
using VetClinic_Server.Data.Models;

namespace VetClinic_Server.Data.DbInitializer
{
    public static class DbInitializer
    {
        public static async Task Initialize(VetClinicDbContext context, UserManager<AppUser> userManager)
        {
            await AppUserInitializer.InitializeUsers(context, userManager);
        }
    }
}
