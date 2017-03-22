using System.Collections.Generic;
using System.Linq;
using PaoinwestAPI.Core.Repositories;

namespace PaoinwestAPI.Persistence.Repositories
{
    public class CustomerRepository : ICustomers
    {
        private readonly NorthwindEntities _context;

        public CustomerRepository(NorthwindEntities context)
        {
            _context = context;
        }

        public Customer GetCustomerById(string CustomerID)
        {
            return _context.Customers
                .SingleOrDefault(a => a.CustomerID == CustomerID);                
        }

        public IEnumerable<Customer> GetCustomers()
        {
            return _context.Customers
                .ToList();
                               
        }

    }
}