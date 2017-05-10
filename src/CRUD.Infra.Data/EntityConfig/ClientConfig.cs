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
    class ClientConfig : EntityTypeConfiguration<Client>
    {
        public ClientConfig()
        {
            // Define that PRIMARY KEY will be the Client ID
            HasKey(c => c.ClientId);

            // For each propriety it's posible to edit its requirements here.
            Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(150)
            ;

            Property(c => c.Document)
                .IsRequired()
                .HasMaxLength(11)
                .IsFixedLength()
                .HasColumnAnnotation("Index", new IndexAnnotation(
                        new IndexAttribute() { IsUnique = true } 
                    )
                )
            ;

            Property(c => c.Active)
                .IsRequired()
            ;
        }
    }
}
