using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VictoriaPlumbing.Domain.Models
{
    public static class InitailData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new VictoriaPlumbingContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<VictoriaPlumbingContext>>()))
            {
                // Look for any movies.
                if (context.CustomerOrder.Any())
                {
                    return;   // DB has been seeded
                }

                context.CustomerOrder.AddRange(
                    new Order
                    {
                        CreatedDate = DateTime.Now,
                        OrderNumber = "ORD-1",
                        BasketCode = "BASKET1"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}