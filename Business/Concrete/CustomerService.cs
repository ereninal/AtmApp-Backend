using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class CustomerService : ICustomerService
    {
        private ICustomerDal _customerDal;

        public CustomerService(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }
        public void Add(Customer customer)
        {
            _customerDal.Add(customer);
        }

        public void Delete(Customer customer)
        {
            _customerDal.Delete(customer);
        }

        public List<Customer> GetAll()
        {
            return _customerDal.GetList().ToList();
        }

        public Customer GetById(int id)
        {
            return _customerDal.Get(b => b.Id == id);
        }

        public void Update(Customer customer)
        {
            _customerDal.Update(customer);
        }
    }
}
