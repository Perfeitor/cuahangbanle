using cuahangbanle.Components.Pages.Manage;
using cuahangbanle.Components.Services;
using cuahangbanle.DBData.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Text;
using System.Threading.Tasks;

namespace cuahangbanle.Data
{
    public static class SeedData
    {
        public static async Task Initialize(IServiceProvider serviceProvider)
        {
            var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            var userManager = serviceProvider.GetRequiredService<UserManager<ApplicationUser>>();

            // Seed roles
            if (!await roleManager.RoleExistsAsync("Admin"))
            {
                await roleManager.CreateAsync(new IdentityRole("Admin"));
            }
            if (!await roleManager.RoleExistsAsync("Manager"))
            {
                await roleManager.CreateAsync(new IdentityRole("Manager"));
            }
            if (!await roleManager.RoleExistsAsync("Staff"))
            {
                await roleManager.CreateAsync(new IdentityRole("Staff"));
            }

            // Seed admin user
            var adminEmail = "admin@gmail.com";
            var adminUser = await userManager.FindByEmailAsync(adminEmail);
            if (adminUser == null)
            {
                adminUser = new ApplicationUser { UserName = adminEmail, Email = adminEmail };
                await userManager.CreateAsync(adminUser, "Abc@123"); // Set a strong password
                await userManager.AddToRoleAsync(adminUser, "Admin");
                var userProfileService = serviceProvider.GetRequiredService<IUserProfileService>(); // Get the UserProfileService from the service provider
                await userProfileService.CreateUserProfile(new UserProfile // Use the CreateUserProfileAsync method
                {
                    UserId = adminUser.Id,
                    Hoten = "Admin"
                });
            }
        }
    }
}