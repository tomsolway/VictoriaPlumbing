using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VictoriaPlumbing.Domain.Models;

namespace VictoriaPlumbing.Infastructure.Mappings
{
    public class OrderClassMap
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable("CustomerOrder");

            builder.Property(t => t.OrderNumber).HasColumnName("OrderNumber");

            builder.Property(t => t.BasketCode).HasColumnName("BasketCode");

            builder.Property(t => t.CustomerEmail).HasColumnName("CustomerEmail");

            builder.Property(t => t.CreatedDate).HasColumnName("CreatedDate");


            // relationships
            builder.HasOne(t => t.Customer)
                .WithMany(t => t.Order)
                .HasForeignKey(d => d.CustomerEmail);

            builder.HasMany(t => t.CustomerItems)
                .WithOne(t => t.Order)
                .HasForeignKey(d => d.OrderNumber);
        }
    }
}
