using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoFilmes.App.Entidades;

namespace ProjetoFilmes.App.Dados.Builder
{
    internal class ModelBuilderFuncionario : ModelBuilderPessoa<Funcionario>
    {
        public override void Configure(EntityTypeBuilder<Funcionario> builder)
        {
            base.Configure(builder);

            builder.ToTable("Staff");

            builder
                .Property(f => f.Id)
                .HasColumnName("Staff_Id");

            builder
                .Property(f => f.Login)
                .HasColumnName("Username")
                .HasColumnType("Varchar(16)")
                .IsRequired();

            builder
                .Property(f => f.Senha)
                .HasColumnName("Password")
                .HasColumnType("Varchar(40)");
        }
    }
}