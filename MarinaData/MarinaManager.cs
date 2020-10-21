using Microsoft.SqlServer.Server;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MarinaData
{
    public  class MarinaManager

    {   public class AvailableSlip
        {
            public int ID { get; set; }
        }




        //define variable
        private static MarinaEntities db = new MarinaEntities();
        //define method to get all the leases 
        public static List<Lease> GetAllLease()
        {        
            var leases = db.Leases.ToList();
            return leases;
        }

        //define method to get all the customer
        public static List<Customer> GetAllCustomer()
        {
          
            var customer = db.Customers.ToList();
            return customer;
        }

        // define method to get all the available slips
        public static List<Slip> GetAvailableSlips()
        {
            List<Slip> aslip = db.Slips.Where(slip => !db.Leases.Select(lease => lease.SlipID)
              .Contains(slip.ID)).ToList();
            return aslip;

        }

        //define method to get docks as selected
        public  static IList GetAllDocksAsList()
        {
            var docks = db.Docks.Select(dks => new { ID = dks.ID, Name = dks.Name }).ToList();
            return docks;
        }

        //define method to get slips by dockid
        public static List<Slip> GetSelectedSlip(int id)
        {
            var aslip = MarinaManager.GetAvailableSlips();
            var sliplist = aslip.Where(slip => slip.DockID == id).ToList();
            return sliplist;

        }

        public static List<Lease> GetCustomerLease(int id)
        {
            var lease = db.Leases.Where(a => a.CustomerID == id).ToList();
            return lease;
        }

        //define method to delete record from available slips
        public static void AddNewLease(int slipid,int cusid)
        {

            var newlease = new Lease { SlipID = slipid, CustomerID = cusid };
            db.Leases.Add(newlease);
            db.SaveChanges();
            
        }
        
     
    }
}
