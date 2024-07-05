using Microsoft.AspNetCore.Identity;
using VetClinic_Server.Data.Models;
using VetClinic_Server.Static;

namespace VetClinic_Server.Data.DbInitializer
{
    public class RoleInitializer
    {
        public static async Task InitializeRoles(VetClinicDbContext context, UserManager<AppUser> userManager, RoleManager<IdentityRole> roleManager)
        { 
            // Define the roles you want to create
            string[] roleNames = { VetClinicConstants.ROLE_ADMIN, VetClinicConstants.ROLE_VET, VetClinicConstants.ROLE_OWNER };

            foreach (var roleName in roleNames)
            {
                var roleExist = await roleManager.RoleExistsAsync(roleName);
                if (!roleExist)
                {
                    // Create the roles and seed them to the database
                    await roleManager.CreateAsync(new IdentityRole(roleName));
                }
            }
        }
    }
}
