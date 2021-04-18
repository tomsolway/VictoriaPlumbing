using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VictoriaPlumbing.Infastructure.Mappings
{
    public class CustomerClassMap
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("Customer");

            builder.Property(t => t.CustomerEmail).HasColumnName("CustomerEmail");

            builder.Property(t => t.Name).HasColumnName("Name");

            builder.HasMany(t => t.Order)
                .WithOne(t => t.Customer)
                .HasForeignKey(d => d.CustomerEmail);
        }
    }
}
