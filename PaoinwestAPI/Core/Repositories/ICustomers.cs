using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaoinwestAPI.Core;
using PaoinwestAPI.Persistence;

namespace PaoinwestAPI.Core.Repositories
{
    public interface ICustomers
    {
        IEnumerable<Customer> GetCustomers();
        Customer GetCustomerById(string CustomerID);
    }
}
