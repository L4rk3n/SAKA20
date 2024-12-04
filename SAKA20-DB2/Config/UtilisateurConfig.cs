using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAKA20_DB.Entities;


namespace SAKA20_DB.Config
{
    public class UtilisateurConfig : IEntityTypeConfiguration<Utilisateur>
    {

        public void Configure(EntityTypeBuilder<Utilisateur> builder)
        {
            builder.HasKey(e => e.IDutilisateur);
            builder
                .Property(e => e.IDutilisateur)
                .ValueGeneratedOnAdd()
                .IsRequired();
            builder
                .Property(e => e.Nom)
                .IsRequired();
            builder
                .Property(e => e.Prenom)
                .IsRequired();
            builder
                .Property(e => e.Email)
                .IsRequired();
            builder
                .Property(e => e.Password);
            builder
                .Property(e => e.PhoneNumber)
                .IsRequired();
            builder
                .Property(e => e.Admin)
                .HasDefaultValue("False")
                .IsRequired();
            builder
                .Property(e => e.Activated)
                .HasDefaultValue("False")
                .IsRequired();
            builder
                .Property(e => e.Cancelled)
                .HasDefaultValue("False")
                .IsRequired();
            builder
                .Property(e => e.AdresseRue)
                .IsRequired();
            builder
                .Property(e => e.AdresseNumero)
                .IsRequired();
            builder
                .Property(e => e.AdresseCodePostal)
                .IsRequired();
            builder
                .Property(e => e.AdresseVille)
                .IsRequired();
            builder
                .Property(e => e.AdresseNumeroBoite);
            builder
                .Property(e => e.AdresseCountry)
                .IsRequired();

        }
    }
}
