using extratinhos.api.DTOs;
using extratinhos.api.Repositories;
using extratinhos.Datasource;
using extratinhos.DTOs;
using extratinhos.Entitys;
using extratinhos.Entitys.Enums;

namespace extratinhos.api.Service;

public class EntryService
{

    private AppDbContext _context;

    public EntryService(AppDbContext context)
    {
        _context = context;
    }
    public void insertEntry(EntryRequest entryrequest, long id)
    {
        var client = new ClientRepository(_context).GetById(id);

        if (client == null)
            throw new ArgumentOutOfRangeException("Client not found");

        Entry entry = new()
        {
            Value = entryrequest.Value,
            Type = entryrequest.Type == "c" ? EntryType.CREDIT : EntryType.DEBIT,
            Description = entryrequest.Description
        };

        new EntrysRepository(_context).Insert(entry);
    }

    public void insertClient(ClientRequest c)
    {
        Client client = new()
        {
            Balance = c.Balance,
            UpdatedAt = DateTime.Now,
            CreatedAt = DateTime.Now
        };
        new ClientRepository(_context).Insert(client);
        var d = _context.SaveChanges();
    }


    public void getBalance(long id)
    {
        var client = new ClientRepository(_context).GetById(id);

        if (client == null)
            throw new ArgumentOutOfRangeException("Client not found");

        //var balance = new 
    }
}
