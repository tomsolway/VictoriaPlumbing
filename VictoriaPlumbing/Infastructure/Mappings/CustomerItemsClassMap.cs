using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VictoriaPlumbing.Domain.Models;

namespace VictoriaPlumbing.Infastructure.Mappings
{
    public class CustomerItemsClassMap
    {
        public void Configure(EntityTypeBuilder<CustomerItems> builder)
        {
            builder.ToTable("CustomerItems");

            builder.Property(t => t.ID).HasColumnName("id");

            builder.Property(t => t.OrderNumber).HasColumnName("OrderNumber");

            builder.Property(t => t.ProductId).HasColumnName("ProductId");

            builder.Property(t => t.Quantity).HasColumnName("Quantity");

            builder.HasOne(t => t.Order)
                .WithMany(t => t.CustomerItems)
                .HasForeignKey(d => d.OrderNumber);
        }
    }
}
