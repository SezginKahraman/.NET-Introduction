using KendiDenemelerim3.Abstract;
using System;

namespace KendiDenemelerim3
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new BaseCustomerManager();
            customerManager.Save(new Customer { DateOfBirth = new DateTime(1956), FirstName = "engin", LastName = "demiorpğ", NationalityId = "213214214" });
        
        
        }
    
    
    
    }



}
