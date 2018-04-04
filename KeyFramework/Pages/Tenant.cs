using KeyFramework.Global;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace KeyFramework.Pages
{
   
    public class Tenant
    {
       
        public string TenantEmail { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string RentStartDate { get; set; }
        public string  RentAmount { get; set; }
        public string PaymentSDate { get; set; }



        public static Dictionary<string, string> ToDictionary(Table table)
        {
            var TenantDetails = new Dictionary<string, string>();
            foreach (var row in table.Rows)
            {
                TenantDetails.Add(row[0], row[1]);
            }
            return TenantDetails;
        }


    }


   

}
