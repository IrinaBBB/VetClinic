using Microsoft.AspNetCore.Identity;
using VetClinic_Server.Data.Models;
using VetClinic_Server.Static;

namespace VetClinic_Server.Data.DbInitializer
{
    public class AppUserInitializer
    {
        public static async Task InitializeUsers(VetClinicDbContext context, UserManager<AppUser> userManager, RoleManager<IdentityRole> roleManager)
        {

            if (!userManager.Users.Any())
            {
                var admin = new AppUser
                {
                    UserName = "admin@admin.no",
                    Email = "admin@admin.no",
                };

                await userManager.CreateAsync(admin, "Pa$$w0rd");
                await userManager.AddToRoleAsync(admin, VetClinicConstants.ROLE_ADMIN);
            }

            List<Specialization> specializations = new();

            if (!context.Specializations.Any())
            {
                specializations.Add(new Specialization { Name = "Veterinary Surgery", Description = "Specializes in performing surgical procedures on animals, including orthopedic, soft tissue, and minimally invasive surgeries." });
                specializations.Add(new Specialization { Name = "Veterinary Dentistry", Description = "Specializes in dental care for animals, including oral surgery, cleanings, and treatments for dental diseases." });
                specializations.Add(new Specialization { Name = "Small Animal Medicine and Surgery", Description = "Focuses on the diagnosis and treatment of diseases and injuries in pets like dogs and cats." });
                specializations.Add(new Specialization { Name = "Exotic Animal Medicine", Description = "Focuses on the diagnosis and treatment of diseases and injuries in pets like dogs and cats." });


                await context.Specializations.AddRangeAsync(specializations);
                await context.SaveChangesAsync();
            }

            if (!context.Vets.Any())
            {
                var vetUser = new AppUser
                {
                    UserName = "kri@uit.no",
                    Email = "kri@uit.no",
                };

                await userManager.CreateAsync(vetUser, "Pa$$w0rd");
                await userManager.AddToRoleAsync(vetUser, VetClinicConstants.ROLE_VET);

                var specialization = specializations.FirstOrDefault() ?? throw new InvalidOperationException("No specializations found. Please ensure the specializations are seeded properly.");
                var vet = new Vet
                {
                    FirstName = "Kris",
                    LastName = "Andreassen",
                    Email = "kri@uit.no",
                    Phone = "23986555",
                    Education = "DVM from University of Veterinary Medicine",
                    Available = true,
                    HasEmergencyCertification = true,
                    Specialization = specializations.FirstOrDefault(),
                    AppUser = vetUser,
                };

                await context.Vets.AddAsync(vet);
                await context.SaveChangesAsync();
            }
        }
    }
}
