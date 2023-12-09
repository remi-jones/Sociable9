using Microsoft.AspNetCore.Identity;

namespace Sociable9.Models
{
    // IdentityDataInitializer class :
    // used to seed the database with the admin user
    // the class will create the admin user with the following information :
    // UserName : admin
    // Email : admin@sociable.com (will be verified automatically)
    // password : Appleapplecak3!
    // the class will also create the Admin Role in the database
    // the class will also associate the admin user with the Admin Role.
    public class IdentityDataInitializer
    {
        public static async Task SeedData(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            await CreateRoles(roleManager); 
            await CreateAdminUser(userManager); 
            await AssignAdminRole(userManager); 
        }
        private static async Task CreateRoles(RoleManager<IdentityRole> roleManager)
        {
            
            // create admin role
            if (!await roleManager.RoleExistsAsync("Admin"))
            {
                await roleManager.CreateAsync(new IdentityRole("Admin"));
            }
        }
        private static async Task CreateAdminUser(UserManager<IdentityUser> userManager)
        {
            // create admin user
            var adminUser = new IdentityUser
            {
                UserName = "admin",
                Email = "admin@sociable.com",
                EmailConfirmed = true
            };

            if (userManager.Users.All(u => u.UserName != adminUser.UserName))
            {
                await userManager.CreateAsync(adminUser, "Appleapplecak3!");
            }
        }

        private static async Task AssignAdminRole(UserManager<IdentityUser> userManager)
        {
            // associate admin user to admin role
            var adminUser = await userManager.FindByEmailAsync("admin@sociable.com");
            if (adminUser != null && !await userManager.IsInRoleAsync(adminUser, "Admin"))
            {
                await userManager.AddToRoleAsync(adminUser, "Admin");
            }
        }
    }
}
