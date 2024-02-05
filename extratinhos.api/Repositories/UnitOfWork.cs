using extratinhos.Datasource;

namespace extratinhos.api.Repositories;

public class UnitOfWork
{
    private AppDbContext _context { get; set; }

    public UnitOfWork(AppDbContext context)
    {
        _context = context;
    }

    public void Commit() =>  _context.SaveChanges();

    public void Rollback() => _context.ChangeTracker.Clear();
}