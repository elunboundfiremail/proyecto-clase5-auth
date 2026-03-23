using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using pw2_clase5.Models;

namespace pw2_clase5.Data
{
    public static class DbSeeder
    {
        public static async Task SeedAsync(ApplicationDbContext context)
        {
            if (!context.Users.Any())
            {
                var users = new List<User>
                {
                    new User { Username = "juan perez", Email = "juan@pw2.com" },
                    new User { Username = "maria garcia", Email = "maria@pw2.com" },
                    new User { Username = "carlos lopez", Email = "carlos@pw2.com" },
                    new User { Username = "ana martinez", Email = "ana@pw2.com" },
                    new User { Username = "luis rodriguez", Email = "luis@pw2.com" }
                };

                context.Users.AddRange(users);
                await context.SaveChangesAsync();
            }
        }
    }
}
