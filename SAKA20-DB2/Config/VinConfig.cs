using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAKA20_DB2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAKA20_DB2.Config
{

        public class VinConfig : IEntityTypeConfiguration<Vin>
        {
            public void Configure(EntityTypeBuilder<Vin> builder)
            {

                builder.HasKey(v => v.Idvin);
                builder
                    .Property(v => v.Idvin)
                    .ValueGeneratedOnAdd()
                    .IsRequired();

                builder.Property(v => v.Nom)
                           .IsRequired()
                           .HasMaxLength(100);

                builder.Property(v => v.Cuvee)
                       .IsRequired();

                builder.Property(v => v.Type)
                           .IsRequired()
                           .HasMaxLength(20);

                builder.Property(v => v.Format)
                       .IsRequired()
                       .HasMaxLength(50);

                builder.Property(v => v.Fournisseur)
                       .IsRequired()
                       .HasMaxLength(100);

                builder.Property(v => v.Disponible)
                       .IsRequired();

                builder.Property(v => v.Stock)
                       .IsRequired();

                builder.Property(v => v.Empalpha)
                       .IsRequired()
                       .HasMaxLength(2);

                builder.Property(v => v.Empnum)
                       .IsRequired();

                builder.Property(v => v.Prix)
                       .IsRequired();

                builder.Property(v => v.Prixtva)
                       .IsRequired();
            }
        }

}
