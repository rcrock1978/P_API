using System.Data.Entity;
using PaoinwestAPI.Core;

namespace PaoinwestAPI.Persistence
{
    public interface INorthWindContext
    {
        DbSet<Customer> Customers { get; set; }
        DbSet<Employee> Employees { get; set; }
        DbSet<Order_Detail> Order_Details { get; set; }
        DbSet<Order> Orders { get; set; }
        DbSet<Product> Products { get; set; }
    }
}
