using extratinhos.Entitys;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace extratinhos.Datasource.Mappers
{
	public class BalanceMap : IEntityTypeConfiguration<Balance>
	{
		public void Configure(EntityTypeBuilder<Balance> builder)
		{
			builder.ToTable(nameof(Balance));

			builder.HasKey(b => b.Id);

			builder.Property(b => b.Id)
				.ValueGeneratedOnAdd()
				.IsRequired();

			builder.Property(b => b.CreatedAt)
				.HasColumnType("datetime")
				.ValueGeneratedOnAdd()
				.IsRequired();

			builder.Property(b => b.UpdatedAt)
				.HasColumnType("datetime")
				.ValueGeneratedOnAddOrUpdate()
				.IsRequired();

			builder.HasOne(b => b.Client)
				.WithOne(c => c.Balance)
				.HasForeignKey<Balance>(b=> b.ClientId)
				.IsRequired();
		}
	}
}
