using Microsoft.AspNetCore.Identity;
using VetClinic_Server.Data.Models;

namespace VetClinic_Server.Data.DbInitializer
{
    public class AppUserInitializer
    {
        public static async Task InitializeUsers(VetClinicDbContext context, UserManager<AppUser> userManager)
        {
            if (!userManager.Users.Any())
            {
                var admin = new AppUser
                {
                    UserName = "admin@admin.no",
                    Email = "admin@admin.no",
                    Vet = null
                };

                await userManager.CreateAsync(admin, "Pa$$w0rd");
                await userManager.AddToRoleAsync(admin, "Admin");

            }
        }
    }
}
