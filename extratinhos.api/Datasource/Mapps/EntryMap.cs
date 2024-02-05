using extratinhos.Entitys;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace extratinhos.Datasource.Mappers
{
	public class EntryMap : IEntityTypeConfiguration<Entry>
	{
		public void Configure(EntityTypeBuilder<Entry> builder)
		{
			builder.ToTable(nameof(Entry));

			builder.HasKey(e => e.Id);

			builder.Property(e => e.Id)
				.ValueGeneratedOnAdd();

			builder.Property(e => e.Description)
				.HasColumnType("text");

			builder.Property(e => e.CreatedAt)
				.HasColumnType("datetime")
				.ValueGeneratedOnAdd()
				.IsRequired();

			builder.Property(e => e.UpdatedAt)
				.HasColumnType("datetime")
				.ValueGeneratedOnAddOrUpdate()
				.IsRequired();

			builder.HasOne(e => e.Client)
				.WithMany(c => c.Entrys)
				.HasForeignKey(e => e.ClientId)
				.IsRequired();
		}
	}
}
