using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PaoinwestAPI.Core;
using PaoinwestAPI.Core.Repositories;
using PaoinwestAPI.Persistence.Repositories;

namespace PaoinwestAPI.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly NorthwindEntities _context;

        public ICustomers Customers  {
            get;
            private set;
        }

        public UnitOfWork(NorthwindEntities context)
        {
            _context = context;
            Customers = new CustomerRepository(context);
        }

        public void Complete() 
        {
            _context.SaveChanges();
        }
    }
}