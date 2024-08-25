using ProvaMVC.Models.Entity;

namespace ProvaMVC.Models.Map
{
    internal class ProfessorMap : IEntityTypeConfiguration<Professor>

    {
        public void Configure(EntityTypeBuilder<Professor> builder)

        {

            builder.ToTable("Professor");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Nome).IsRequired();

            builder.Property(x => x.Email).IsRequired();

        }

    }
}
