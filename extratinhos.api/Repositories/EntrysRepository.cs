﻿using extratinhos.Datasource;
using extratinhos.Entitys;

using Microsoft.EntityFrameworkCore;

namespace extratinhos.api.Repositories;

public class EntrysRepository : IRepository<Entry>
{
    private AppDbContext _context;

    public EntrysRepository(AppDbContext context)
    {
        _context = context;
    }

    public List<Entry> GetAll()
        => _context.Entries.AsNoTracking().ToList();

    public Entry? GetById(long id)
        => _context.Entries.FirstOrDefault(x => x.Id == id);

    public IRepository<Entry> Insert(Entry entity)
    {
        _context.Entries.Add(entity);
        return this;
    }

    public IRepository<Entry> InsertRange(List<Entry> entitys)
    {
        _context.Entries.AddRange(entitys);
        return this;
    }

    public void Save() => _context.SaveChanges();

    public IRepository<Entry> Update(Entry entity)
    {
        entity.UpdatedAt = DateTime.Now;
        _context.Entries.Update(entity);
        return this;
    }
}
