
using PaoinwestAPI.Core.Repositories;

namespace PaoinwestAPI.Core
{
    public interface IUnitOfWork
    {
        ICustomers Customers { get; }
        void Complete();
    }
}
