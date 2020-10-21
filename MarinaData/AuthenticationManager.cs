using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarinaData
{
   public class AuthenticationManager
    {
        
        public static CustomerDTO Authenticate(string firstname, string lastname)
        {
            CustomerDTO dto = null;
            var db = new MarinaEntities();
            var cus = db.Customers.
                SingleOrDefault(a => a.FirstName == firstname && a.LastName == lastname);
            if (cus != null) // authentication passsed
            {
                dto = new CustomerDTO
                {
                    ID = cus.ID,
                    FullName = $"{cus.FirstName} {cus.LastName}"
                };
            }
            return dto;
        }

        public static Customer Find(int customerID)
        {
            var db = new MarinaEntities();
            var cus = db.Customers.
                SingleOrDefault(a => a.ID == customerID);
            return cus;
        }

        public static void Add(Customer cus)
        {
            var db = new MarinaEntities();
            db.Customers.Add(cus);
            db.SaveChanges();
        }

        public static void Update(Customer cus)
        {
            var db = new MarinaEntities();
            var cusFromContext = db.Customers.SingleOrDefault(a => a.FirstName == cus.FirstName&&a.LastName==cus.
            LastName);
          
            cusFromContext.FirstName = cus.FirstName;
            cusFromContext.LastName = cus.LastName;
            cusFromContext.Phone= cus.Phone;
            cusFromContext.City = cus.City;
            db.SaveChanges();
        }
    }
}
