using extratinhos.Entitys;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace extratinhos.Datasource.Mappers
{
	public class ClientMap : IEntityTypeConfiguration<Client>
	{
		public void Configure(EntityTypeBuilder<Client> builder)
		{
			builder.ToTable(nameof(Client));

			builder.HasKey(c => c.Id);

			builder.Property(c => c.Id)
				.ValueGeneratedOnAdd();

			builder.Property(c => c.Limit)
				.IsRequired();

			builder.Property(c => c.CreatedAt)
				.HasColumnType("timestamp")
                .HasDefaultValueSql("now()")
                .IsRequired();

            builder.Property(c => c.UpdatedAt)
				.HasColumnType("timestamp")
                .HasDefaultValueSql("now()")
                .IsRequired();
        }
	}
}
