using extratinhos.Datasource.Mappers;
using extratinhos.Entitys;
using Microsoft.EntityFrameworkCore;

namespace extratinhos.Datasource
{
	public class AppDbContext : DbContext
	{
		public DbSet<Client> Clients { get; set; }

		public DbSet<Entry> Entries { get; set; }

		public DbSet<Balance> Balances { get; set; }

		public AppDbContext(DbContextOptions options) : base(options)
		{
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfiguration(new EntryMap());
			modelBuilder.ApplyConfiguration(new ClientMap());
			modelBuilder.ApplyConfiguration(new BalanceMap());

			modelBuilder.Entity<Client>()
				.HasData(
				  new Client { Id = 1, Limit = 100000 },
				  new Client { Id = 2, Limit = 80000 },
				  new Client { Id = 3, Limit = 1000000 },
				  new Client { Id = 4, Limit = 10000000 },
				  new Client { Id = 5, Limit = 500000 }
				  );
		}
	}
}
