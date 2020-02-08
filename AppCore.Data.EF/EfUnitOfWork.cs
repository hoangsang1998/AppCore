using AppCore.Infrastucture.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppCore.Data.EF
{
    public class EfUnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;
        public EfUnitOfWork(AppDbContext context)
        {
            _context = context;
        }
        public void commit()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
