using System;
using System.Collections.Generic;
using System.Text;

namespace KendiDenemelerim3.Abstract
{
    class BaseCustomerManager : ICustomerService
    {
        public void Save(Customer customer)
        {
            Console.WriteLine("saved to db"+customer.FirstName);
        }
    }
}
