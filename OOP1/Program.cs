using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            IndividualCustomer individualCustomer1 = new IndividualCustomer();
            individualCustomer1.Id = 1;
            individualCustomer1.PersonelId = "1234567890";
            individualCustomer1.CustomerId = 12345;
            individualCustomer1.FirsName = "Merve";
            individualCustomer1.LastName = "Yılmaz";

            CorporateCustomer corporateCustomer1 = new CorporateCustomer() { Id = 2 , CustomerId=54321, CompanyName="A", Tax="8945712" };

            Customer customer3 = new CorporateCustomer();
            Customer customer4 = new IndividualCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(corporateCustomer1);
            


                 

        }
    }
}
