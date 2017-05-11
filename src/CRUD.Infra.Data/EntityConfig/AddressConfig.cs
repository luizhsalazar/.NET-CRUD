using CRUD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Infra.Data.EntityConfig
{
    // Fluent API
    class AddressConfig : EntityTypeConfiguration<Address>
    {
        public AddressConfig()
        {
            // Define that PRIMARY KEY will be the Client ID
            HasKey(c => c.AddressId);

            // For each propriety it's posible to edit its requirements here.
            Property(c => c.Location)
                //.IsRequired()
                .HasMaxLength(150)
            ;

            Property(c => c.Number)
                //.IsRequired()
                .HasMaxLength(20)
            ;

            Property(c => c.Neighborhood)
                //.IsRequired()
                .HasMaxLength(50)
            ;
            
            Property(c => c.ZipCode)
                //.IsRequired()
                .HasMaxLength(8)
                .IsFixedLength()
            ;

            // In the relationship side, all requirements must be set (foreign key, relation, etc)
            HasRequired(e => e.Client)
                .WithMany(c => c.Addresses)
                .HasForeignKey(e => e.ClientId)
            ;
        }
    }
}
