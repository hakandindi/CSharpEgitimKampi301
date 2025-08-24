using CSharpEgitimKampi301.BusinessLayer.Abstract;
using CSharpEgitimKampi301.EFProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.BusinessLayer.Concrete
{
    public class CustomerManager : ICustomerService
    {
        public void TDelete(Customer entity)
        {
            throw new NotImplementedException();
        }

        public List<Customer> TGetAll()
        {
            throw new NotImplementedException();
        }

        public Customer TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TInsert(Customer entity)
        {
            if (entity.CustomerName != "" && entity.CustomerName.Length >= 3 && entity.CustomerCity != null && entity.CustomerSurname != "" && entity.CustomerSurname.Length <= 30)
            {

            }
        }

        public void TUpdate(Customer entity)
        {
            throw new NotImplementedException();
        }
    }
}
