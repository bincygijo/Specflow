using KeyFramework.Global;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyFramework.Pages
{
    class TenantPOM
    {
        // Initializing the web elements 
        //public TenantPOM()
        //{
        //    PageFactory.InitElements(Driver.driver, this);
        //}


        //Enter tenant email
        [FindsBy(How = How.XPath, Using = "//*[@id='BasicDetail']/div[2]/div[1]/div/input")]
        public IWebElement TEmail { get; set; }


        //Finding FirstName
        [FindsBy(How = How.XPath, Using = "//*[@id='BasicDetail']/div[3]/div[1]/div/input")]
        public IWebElement FName { get; set; }

        //Finding LastName
        [FindsBy(How = How.XPath, Using = "//fieldset[@id='BasicDetail']//div[3]/div[2]")]
        public IWebElement LName { get; set; }

        //Rent Start date
        [FindsBy(How = How.XPath, Using = "//*[@id='BasicDetail']/div[4]/div[1]/div/input")]
        public IWebElement RentSDate { get; set; }

        //Rent Amount
        [FindsBy(How = How.XPath, Using = "//*[@id='BasicDetail']/div[5]/div[1]/div/input")]
        public IWebElement Rentamount { get; set; }

        //payment start date
        [FindsBy(How = How.XPath, Using = "//*[@id='BasicDetail']/div[6]/div[1]/div/input")]
        public IWebElement PaymentDate { get; set; }

        //clicking next button
        [FindsBy(How = How.XPath, Using = "//input[@class='btn btn-success']")]
        public IWebElement NextB  { get; set; }

        //checking page redirected to liabilities
        [FindsBy(How = How.XPath, Using = "//li[@id='liabilities']")]
        public IWebElement ResultLib { get; set; }

        //clicking Add New Liability
        [FindsBy(How = How.XPath, Using = "//fieldset[@id='LiabilityDetail']/div/div//a")]
        public IWebElement ClickLib { get; set; }

        //Enter Amount
        [FindsBy(How = How.XPath, Using = "//table[@class='table-financial table-properties property-projections table']/tbody/tr/td[2]/input")]
        public IWebElement Amount { get; set; }

        //clicking Next button
        [FindsBy(How = How.XPath, Using = "//div[@class='col-sm-12 text-center']/button[text()='Next']")]
        public IWebElement ClickNext { get; set; }

        //clicking on submit button
        [FindsBy(How = How.XPath, Using = "//div[@class='col-sm-12 text-center']/button[text()='Submit']")]
        public IWebElement submitBu { get; set; }
        


    }
}
