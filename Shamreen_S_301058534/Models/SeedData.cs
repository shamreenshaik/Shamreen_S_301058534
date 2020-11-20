using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shamreen_S_301058534.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices
                .GetRequiredService<ApplicationDbContext>();
            context.Database.Migrate();
            if (!context.Clubs.Any())
            {
                context.Clubs.AddRange(
                    new Club
                    {
                        Name = "Kayak",
                        Club_Description = "A boat for one person",
                        Club_City = "Watersports",
                        Club_Value = 275m,
                        Club_Manger = "ss",
                        Club_Owner = "yty",
                        Id = 1
                
                     });
                    
                context.SaveChanges();
            }
        }
    }
}

