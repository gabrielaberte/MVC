using ProvaMVC.Models.Entity;

namespace ProvaMVC.Models.Map
{
    internal class MatriculaMap : IEntityTypeConfiguration<Matricula>
    {
        public void Configure(EntityTypeBuilder<Matricula> builder)
        {
            builder.ToTable("Matricula");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.DataMatricula).IsRequired();

            builder.Property(x => x.Status).IsRequired();

        }
    }
}
