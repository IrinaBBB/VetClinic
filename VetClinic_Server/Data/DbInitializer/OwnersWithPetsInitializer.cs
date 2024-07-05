using Microsoft.AspNetCore.Identity;
using VetClinic_Server.Data.Models;
using VetClinic_Server.Static;

namespace VetClinic_Server.Data.DbInitializer
{
    public static class OwnersWithPetsInitializer
    {
        public static async Task InitializeOwnersWithPets(VetClinicDbContext context, UserManager<AppUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            List<Species> species = new List<Species>();

            if (!context.Species.Any())
            {
                species.Add( new Species
                {
                    Name = "Canine",
                    Description = "Dogs and related species."
                });
                species.Add(new Species
                {
                    Name = "Feline",
                    Description = "Cats and related species."
                });
                species.Add(new Species
                {
                    Name = "Avian",
                    Description = "Birds of various species."
                });
                species.Add(new Species
                {
                    Name = "Reptile",
                    Description = "Reptiles including snakes, lizards, and turtles."
                });
                species.Add(new Species
                {
                    Name = "Rodent",
                    Description = "Small mammals such as mice, rats, and guinea pigs."
                });


                await context.Species.AddRangeAsync(species);
                await context.SaveChangesAsync();
            }

            if (!context.Owners.Any())
            {
                var ownerUser1 = new AppUser
                {
                    UserName = "anna@uit.no",
                    Email = "anna@uit.no",
                };

                await userManager.CreateAsync(ownerUser1, "Pa$$w0rd");
                await userManager.AddToRoleAsync(ownerUser1, VetClinicConstants.ROLE_OWNER);

                var owner1 = new Owner
                {
                    FirstName = "Anna",
                    LastName = "Larsen",
                    Email = "anna@uit.no",
                    PhoneNumber = "23986555",
                    Address = "Maple St. 233",
                    AppUser = ownerUser1,
                };

                await context.Owners.AddAsync(owner1);

                var ownerUser2 = new AppUser
                {
                    UserName = "ben@uit.no",
                    Email = "ben@uit.no",
                };

                await userManager.CreateAsync(ownerUser2, "Pa$$w0rd");
                await userManager.AddToRoleAsync(ownerUser2, VetClinicConstants.ROLE_OWNER);

                var owner2 = new Owner
                {
                    FirstName = "Ben",
                    LastName = "Johnson",
                    Email = "ben@uit.no",
                    PhoneNumber = "12345678",
                    Address = "Oak St. 101",
                    AppUser = ownerUser2,
                };

                await context.Owners.AddAsync(owner2);

                var ownerUser3 = new AppUser
                {
                    UserName = "clara@uit.no",
                    Email = "clara@uit.no",
                };

                await userManager.CreateAsync(ownerUser3, "Pa$$w0rd");
                await userManager.AddToRoleAsync(ownerUser3, VetClinicConstants.ROLE_OWNER);

                var owner3 = new Owner
                {
                    FirstName = "Clara",
                    LastName = "Smith",
                    Email = "clara@uit.no",
                    PhoneNumber = "87654321",
                    Address = "Pine St. 456",
                    AppUser = ownerUser3,
                };

                await context.Owners.AddAsync(owner3);


                var pet1 = new Pet { Name = "Buddy", Species = species.ElementAt(0), Sex = Sex.Male, IsNeutered = false, Owner = owner1 };
                await context.Pets.AddAsync(pet1);

                var pet2 = new Pet { Name = "Mittens", Species = species.ElementAt(1), Sex = Sex.Female, IsNeutered = true, Owner = owner2 };
                await context.Pets.AddAsync(pet2);

                var pet3 = new Pet { Name = "Luna", Species = species.ElementAt(2), Sex = Sex.Female, IsNeutered = false, Owner = owner2 };
                await context.Pets.AddAsync(pet3);

                await context.SaveChangesAsync();
            }
        }
    }
}
