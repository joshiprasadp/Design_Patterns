using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practice.Web.Models
{
    public class EFCustomerRepository : ICustomerRepository
    {
        private PracticeWebContext db = new PracticeWebContext();

        public IQueryable<Customer> Customers
        {
            get
            {
                return db.Customers;
            } 
        }

        public void Delete(Customer customer)
        {
            db.Entry(customer).State = System.Data.Entity.EntityState.Deleted;
            db.SaveChanges();
        }

        public Customer Find(int? id)
        {
            Customer customer = db.Customers.Find(id);
            return customer;
        }

        public Customer Save(Customer customer)
        {
            if (customer.CustId==0)
            {
                db.Customers.Add(customer);
            }
            else
            {
                db.Entry<Customer>(customer).State = System.Data.Entity.EntityState.Modified;
            }
            db.SaveChanges();
            return customer;
        }
    }
}