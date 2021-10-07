using Models;
using System.Collections.Generic;
using StoreDL;

namespace StoreBL
{
    public interface ICustomerBL
    {
        void AddCustomer(CCustomers customer);

        List<CCustomers> GetAllCustomer();

        CCustomers FindCustomer(int CustomerId);

        List<Order> OrderHistory();
    }
}