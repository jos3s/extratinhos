﻿using extratinhos.Datasource;
using extratinhos.Entitys;

using Microsoft.EntityFrameworkCore;

namespace extratinhos.api.Repositories;

public class BalanceRepository : IRepository<Balance>
{
    private readonly AppDbContext _context;

    public BalanceRepository(AppDbContext context)
    {
        _context = context;
    }

    public List<Balance> GetAll()
        => _context.Balances.AsNoTracking().ToList();

    public Balance? GetById(long id)
        => _context.Balances.FirstOrDefault(x => x.Id == id);

    public IRepository<Balance> Insert(Balance entity)
    {
        _context.Balances.Add(entity);
        return this;
    }

    public IRepository<Balance> InsertRange(List<Balance> entitys)
    {
        _context.Balances.AddRange(entitys);
        return this;
    }

    public void Save() => _context.SaveChanges();

    public IRepository<Balance> Update(Balance entity)
    {
        entity.UpdatedAt = DateTime.Now;
        _context.Balances.Update(entity);
        return this;
    }
}
