using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practice.Web.Models
{
    public interface ICustomerRepository
    {
        IQueryable<Customer> Customers { get; }
        Customer Save(Customer customer);
        void Delete(Customer customer);
        Customer Find(int? id);
    }
}