using ProvaMVC.Models.Entity;

namespace ProvaMVC.Models.Map
{
    internal class CursoMap : IEntityTypeConfiguration<Curso>
    {
        public void Configure(EntityTypeBuilder<Curso> builder)
        {
            builder.ToTable("Curso");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Titulo).IsRequired();

            builder.Property(x => x.Descricao).IsRequired();

            builder.Property(x => x.Ativo).IsRequired();

            builder.Property(x => x.Vagas).IsRequired();

        }
    }
}
