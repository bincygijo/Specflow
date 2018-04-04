using KeyFramework.Global;
using KeyFramework.Test;
using OpenQA.Selenium;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static KeyFramework.Global.CommonMethods;
//using AutoItX3Lib;

namespace KeyFramework.Pages
{
   public class Property
    {
        #region addproperty
        public void AddProperty()
        {
           
            try
            {
                //Populate in collection
                CommonMethods.ExcelLib.PopulateInCollection(Base.ExcelPath, "Property");

                //Scroll a page up
                //IJavaScriptExecutor js = (IJavaScriptExecutor)Driver.driver;
                //js.ExecuteScript("window.scrollTo(0, 200);");

                //Clicking on Owner dropdown
                Driver.ActionButton(Driver.driver, ExcelLib.ReadData(2, "Locator"), ExcelLib.ReadData(2, "LocatorValue"));
                Thread.Sleep(2000);

                //clicking on properties 
                Driver.ActionButton(Driver.driver, ExcelLib.ReadData(3, "Locator"), ExcelLib.ReadData(3, "LocatorValue"));
                Thread.Sleep(2000);

                //clicking on Add New Property
                Driver.ActionButton(Driver.driver, ExcelLib.ReadData(4, "Locator"), ExcelLib.ReadData(4, "LocatorValue"));
                Thread.Sleep(2000);

                //Enter Property Name
                Driver.Textbox(Driver.driver, ExcelLib.ReadData(5, "Locator"), ExcelLib.ReadData(5, "LocatorValue"), ExcelLib.ReadData(5, "InputValue"));
                Thread.Sleep(2000);

                //Enter Description
                Driver.Textbox(Driver.driver, ExcelLib.ReadData(6, "Locator"), ExcelLib.ReadData(6, "LocatorValue"), ExcelLib.ReadData(6, "InputValue"));
                Thread.Sleep(2000);

                //Scroll a page down
                //IJavaScriptExecutor js = (IJavaScriptExecutor)Driver.driver;
                //js.ExecuteScript("window.scrollTo(0, 200);");

                //Enter Number
                Driver.Textbox(Driver.driver, ExcelLib.ReadData(7, "Locator"), ExcelLib.ReadData(7, "LocatorValue"), ExcelLib.ReadData(7, "InputValue"));
                Thread.Sleep(2000);

                //Enter Street
                Driver.Textbox(Driver.driver, ExcelLib.ReadData(8, "Locator"), ExcelLib.ReadData(8, "LocatorValue"), ExcelLib.ReadData(8, "InputValue"));
                Thread.Sleep(2000);

                //Enter city
                Driver.Textbox(Driver.driver, ExcelLib.ReadData(9, "Locator"), ExcelLib.ReadData(9, "LocatorValue"), ExcelLib.ReadData(9, "InputValue"));
                Thread.Sleep(2000);

                //Enter Postcode
                Driver.Textbox(Driver.driver, ExcelLib.ReadData(10, "Locator"), ExcelLib.ReadData(10, "LocatorValue"), ExcelLib.ReadData(10, "InputValue"));
                Thread.Sleep(2000);

                //Scroll a page down
                IJavaScriptExecutor js1 = (IJavaScriptExecutor)Driver.driver;
                js1.ExecuteScript("window.scrollTo(0, 200);");

                //Enter Region
                Driver.Textbox(Driver.driver, ExcelLib.ReadData(11, "Locator"), ExcelLib.ReadData(11, "LocatorValue"), ExcelLib.ReadData(11, "InputValue"));
                Thread.Sleep(2000);

                //Enter Year Built
                Driver.Textbox(Driver.driver, ExcelLib.ReadData(12, "Locator"), ExcelLib.ReadData(12, "LocatorValue"), ExcelLib.ReadData(12, "InputValue"));
                Thread.Sleep(2000);

                //Scroll a page down
                IJavaScriptExecutor js = (IJavaScriptExecutor)Driver.driver;
                js1.ExecuteScript("window.scrollTo(0, 200);");

                //Enter Target rent
                Driver.Textbox(Driver.driver, ExcelLib.ReadData(13, "Locator"), ExcelLib.ReadData(13, "LocatorValue"), ExcelLib.ReadData(13, "InputValue"));
                Thread.Sleep(2000);

                //Enter Bedroom
                Driver.Textbox(Driver.driver, ExcelLib.ReadData(14, "Locator"), ExcelLib.ReadData(14, "LocatorValue"), ExcelLib.ReadData(14, "InputValue"));
                Thread.Sleep(2000);

                //Enter Bathroom
                Driver.Textbox(Driver.driver, ExcelLib.ReadData(15, "Locator"), ExcelLib.ReadData(15, "LocatorValue"), ExcelLib.ReadData(15, "InputValue"));
                Thread.Sleep(2000);

                //Enter Carpark
                Driver.Textbox(Driver.driver, ExcelLib.ReadData(16, "Locator"), ExcelLib.ReadData(16, "LocatorValue"), ExcelLib.ReadData(16, "InputValue"));
                Thread.Sleep(2000);

                //Scroll a page down
                //IJavaScriptExecutor js2 = (IJavaScriptExecutor)Driver.driver;
                //js2.ExecuteScript("window.scrollTo(0, 50);");

                //Clicking on Next button
                Driver.ActionButton(Driver.driver, ExcelLib.ReadData(17, "Locator"), ExcelLib.ReadData(17, "LocatorValue"));
                Thread.Sleep(2000);

                //Adding Financial details
                AddFinancialDetails();

                //Add Tenant details
                AddTenantDetails();

                //Screenshot
                SaveScreenShotClass.SaveScreenshot(Driver.driver, "Tenant and property");

                //Report
                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Property and tenant added sucessfully");

                //Checking successful message
                //var ExpectedRes = "Property created successfully";
                //var ActualRes = 

            }
            catch (Exception e)
            {
                Base.test.Log(LogStatus.Error, "There is an error: " + e);
                Console.WriteLine("There is an error: " + e);

            }
        }
        #endregion

        #region financialdetails
        public void AddFinancialDetails()
        {

            try
            {
                //Populate in collection
                CommonMethods.ExcelLib.PopulateInCollection(Base.ExcelPath, "FinancialDetails");

                //Enter Purchase price
                Driver.Textbox(Driver.driver, ExcelLib.ReadData(2, "Locator"), ExcelLib.ReadData(2, "LocatorValue"), ExcelLib.ReadData(2, "InputValue"));
                Thread.Sleep(2000);

                //Enter Mortgage
                Driver.Textbox(Driver.driver, ExcelLib.ReadData(3, "Locator"), ExcelLib.ReadData(3, "LocatorValue"), ExcelLib.ReadData(3, "InputValue"));
                Thread.Sleep(2000);

                //Enter Home Value
                Driver.Textbox(Driver.driver, ExcelLib.ReadData(4, "Locator"), ExcelLib.ReadData(4, "LocatorValue"), ExcelLib.ReadData(4, "InputValue"));
                Thread.Sleep(2000);

                //Clicking on Next button
                Driver.ActionButton(Driver.driver, ExcelLib.ReadData(5, "Locator"), ExcelLib.ReadData(5, "LocatorValue"));
                Thread.Sleep(2000);

            }
            catch(Exception e)
            {
                Base.test.Log(LogStatus.Error, "There is an error: " + e);
                Console.WriteLine("There is an error: " + e);
            }
        }

        #endregion

        #region TenantDetails
        public void AddTenantDetails()
        {
            try
            {
                //Populate in collection
                CommonMethods.ExcelLib.PopulateInCollection(Base.ExcelPath, "TenantDetails");

                //Enter Tenant email
                Driver.Textbox(Driver.driver, ExcelLib.ReadData(2, "Locator"), ExcelLib.ReadData(2, "LocatorValue"), ExcelLib.ReadData(2, "InputValue"));
                Thread.Sleep(2000);

                //Enter Firstname
                Driver.Textbox(Driver.driver, ExcelLib.ReadData(3, "Locator"), ExcelLib.ReadData(3, "LocatorValue"), ExcelLib.ReadData(3, "InputValue"));
                Thread.Sleep(2000);

                //Enter Lastname
                Driver.Textbox(Driver.driver, ExcelLib.ReadData(4, "Locator"), ExcelLib.ReadData(4, "LocatorValue"), ExcelLib.ReadData(4, "InputValue"));
                Thread.Sleep(2000);

                //Enter start date
                Driver.ActionButton(Driver.driver, ExcelLib.ReadData(5, "Locator"), ExcelLib.ReadData(5, "LocatorValue"));
                Thread.Sleep(2000);

                Driver.GetClear(Driver.driver, ExcelLib.ReadData(5, "Locator"), ExcelLib.ReadData(5, "LocatorValue"));
                          
                Driver.Textbox(Driver.driver, ExcelLib.ReadData(5, "Locator"), ExcelLib.ReadData(5, "LocatorValue"), ExcelLib.ReadData(5, "InputValue"));
                Thread.Sleep(2000);

                //Enter end date

                Driver.ActionButton(Driver.driver, ExcelLib.ReadData(6, "Locator"), ExcelLib.ReadData(6, "LocatorValue"));
                Thread.Sleep(2000);

                Driver.GetClear(Driver.driver, ExcelLib.ReadData(6, "Locator"), ExcelLib.ReadData(6, "LocatorValue"));

                Driver.Textbox(Driver.driver, ExcelLib.ReadData(6, "Locator"), ExcelLib.ReadData(6, "LocatorValue"), ExcelLib.ReadData(6, "InputValue"));
                Thread.Sleep(2000);

                //Enter rent amount
                Driver.Textbox(Driver.driver, ExcelLib.ReadData(7, "Locator"), ExcelLib.ReadData(7, "LocatorValue"), ExcelLib.ReadData(7, "InputValue"));
                Thread.Sleep(2000);

                //Select the payment frequency type
                Driver.ActionButton(Driver.driver, ExcelLib.ReadData(8, "Locator"), ExcelLib.ReadData(8, "LocatorValue"));
                Thread.Sleep(2000);

                IList<IWebElement> frequencytypes = Driver.driver.FindElements(By.XPath("//*[@id='tenantSection']/div[4]/div/div/select"));

                int FrequencyTypeCount = frequencytypes.Count();

                for (int i = 0; i < FrequencyTypeCount; i++)
                {
                    if (frequencytypes[i].Text == "Fortnightly")
                    {
                        frequencytypes[i].Click();
                    }
                }
                Thread.Sleep(2000);

                //payment start date

                Driver.ActionButton(Driver.driver, ExcelLib.ReadData(9, "Locator"), ExcelLib.ReadData(9, "LocatorValue"));
                Thread.Sleep(2000);

                Driver.GetClear(Driver.driver, ExcelLib.ReadData(9, "Locator"), ExcelLib.ReadData(9, "LocatorValue"));

                Driver.Textbox(Driver.driver, ExcelLib.ReadData(9, "Locator"), ExcelLib.ReadData(9, "LocatorValue"), ExcelLib.ReadData(9, "InputValue"));
                Thread.Sleep(2000);

                //payment due day
                Driver.ActionButton(Driver.driver, ExcelLib.ReadData(10, "Locator"), ExcelLib.ReadData(10, "LocatorValue"));
                Thread.Sleep(2000);
                IList<IWebElement> paymentdueday = Driver.driver.FindElements(By.XPath("//*[@id='tenantSection']/div[5]/div[2]/div/select"));

                int countpayment = paymentdueday.Count();

                for (int i = 0; i < countpayment; i++)
                {
                    if (paymentdueday[i].Text == "4")
                    {
                        paymentdueday[i].Click();
                    }
                }
                Thread.Sleep(2000);

                //click save button
                Driver.ActionButton(Driver.driver, ExcelLib.ReadData(11, "Locator"), ExcelLib.ReadData(11, "LocatorValue"));
                Thread.Sleep(2000);
                
                //check  the newely added property listed in prperty page
                //search for added property
                Driver.Textbox(Driver.driver, ExcelLib.ReadData(12, "Locator"), ExcelLib.ReadData(12, "LocatorValue"), ExcelLib.ReadData(12, "InputValue"));
                Thread.Sleep(2000);

                //click search buttons
                Driver.ActionButton(Driver.driver, ExcelLib.ReadData(13, "Locator"), ExcelLib.ReadData(13, "LocatorValue"));
                Thread.Sleep(2000);

                //var ActResult = "available for rent";
                IWebElement ExpResult = Driver.driver.FindElement(By.XPath("//*[@id='main - content']/section/div[1]/div[1]/div[4]/div/div/div/div[2]/div[2]/div[1]/div[1]/div[1]"));
                //if(ActResult.ToLower == ExpResult)
                //{
                //    Base.test.Log(LogStatus.Pass, "Test Passed, Property Listed successfully.");
                //}
                //else
                //{
                //    Base.test.Log(LogStatus.Fail, "Test failed, Property not found.");
                //}
               


            }
            catch(Exception e)
            {
                Base.test.Log(LogStatus.Error, "There is an error: " + e);
                Console.WriteLine("There is an error: " + e);
            }
        }

        #endregion

        #region checking * marks
        public void ValidateMandatoryFields()
        {
            //Populate in collection
            CommonMethods.ExcelLib.PopulateInCollection(Base.ExcelPath, "Property");

            //Clicking on Owner dropdown
            Driver.ActionButton(Driver.driver, ExcelLib.ReadData(2, "Locator"), ExcelLib.ReadData(2, "LocatorValue"));
            Thread.Sleep(2000);

            //clicking on properties 
            Driver.ActionButton(Driver.driver, ExcelLib.ReadData(3, "Locator"), ExcelLib.ReadData(3, "LocatorValue"));
            Thread.Sleep(2000);

            //clicking on Add New Property
            Driver.ActionButton(Driver.driver, ExcelLib.ReadData(4, "Locator"), ExcelLib.ReadData(4, "LocatorValue"));
            Thread.Sleep(2000);

            if (Driver.isDialogPresent(Driver.driver, ExcelLib.ReadData(19, "Locator"), ExcelLib.ReadData(19, "LocatorValue")))
                Console.WriteLine("Please enter your property's name.");
            

            else
                Console.WriteLine("Elements not present");
        }
        #endregion

        #region
        public void DeleteProperty()
        {
            //Populate in collection
            CommonMethods.ExcelLib.PopulateInCollection(Base.ExcelPath, "Property");

            //Scroll a page up
            //IJavaScriptExecutor js = (IJavaScriptExecutor)Driver.driver;
            //js.ExecuteScript("window.scrollTo(0, 200);");

            //Clicking on Owner dropdown
            Driver.ActionButton(Driver.driver, ExcelLib.ReadData(2, "Locator"), ExcelLib.ReadData(2, "LocatorValue"));
            Thread.Sleep(2000);

            //clicking on properties 
            Driver.ActionButton(Driver.driver, ExcelLib.ReadData(3, "Locator"), ExcelLib.ReadData(3, "LocatorValue"));
            Thread.Sleep(2000);

                //Populate in collection
                CommonMethods.ExcelLib.PopulateInCollection(Base.ExcelPath, "Property");

                //Clicking on Owner dropdown
                Driver.ActionButton(Driver.driver, ExcelLib.ReadData(2, "Locator"), ExcelLib.ReadData(2, "LocatorValue"));
                Thread.Sleep(2000);

                //clicking on properties 
                Driver.ActionButton(Driver.driver, ExcelLib.ReadData(3, "Locator"), ExcelLib.ReadData(3, "LocatorValue"));
                Thread.Sleep(2000);

            //Searching for data
            Driver.Textbox(Driver.driver, ExcelLib.ReadData(20, "Locator"), ExcelLib.ReadData(20, "LocatorValue"), ExcelLib.ReadData(20, "InputValue"));
            Thread.Sleep(2000);

            //Click on search button
            Driver.ActionButton(Driver.driver, ExcelLib.ReadData(21, "Locator"), ExcelLib.ReadData(21, "LocatorValue"));
            Thread.Sleep(2000);


        }
        #endregion

        #region
        public void OwnerDashboard()
        {

            //Populate in collection
            CommonMethods.ExcelLib.PopulateInCollection(Base.ExcelPath, "Property");

            //Clicking on Owner dropdown
            Driver.ActionButton(Driver.driver, ExcelLib.ReadData(2, "Locator"), ExcelLib.ReadData(2, "LocatorValue"));
            Thread.Sleep(2000);

            //clicking on properties 
            Driver.ActionButton(Driver.driver, ExcelLib.ReadData(3, "Locator"), ExcelLib.ReadData(3, "LocatorValue"));
            Thread.Sleep(2000);

           

        }
        #endregion
    }
}
