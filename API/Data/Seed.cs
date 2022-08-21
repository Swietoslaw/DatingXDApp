using System.Text.Json;
using API.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class Seed
    {
        public static async Task SeedUsers(UserManager<AppUser> userMenager)
        {
            if (await userMenager.Users.AnyAsync()) return;

            var userData = await System.IO.File.ReadAllTextAsync("Data/UserSeedData.json");
            var users = JsonSerializer.Deserialize<List<AppUser>>(userData);
            if(users == null) return;
            
            foreach (var user in users)
            {
                user.UserName = user.UserName.ToLower();
                await userMenager.CreateAsync(user, "Pa$$w0rd");
            }
        }
    }
}