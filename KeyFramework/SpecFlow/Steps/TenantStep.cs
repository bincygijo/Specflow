using KeyFramework.Config;
using KeyFramework.Global;
using KeyFramework.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using RelevantCodes.ExtentReports;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using static KeyFramework.Global.CommonMethods;

namespace KeyFramework.SpecFlow.Steps
{
    [Binding]
    public class TenantStep:Global.Base
    {
        [BeforeScenario]
        public void BeforeScenario()
        {

            // advisasble to read this documentation before proceeding http://extentreports.relevantcodes.com/net/
            switch (Browser)
            {
                case 1:
                    Driver.driver = new FirefoxDriver();
                    break;
                case 2:
                    //ChromeOptions options = new ChromeOptions();
                    var options = new ChromeOptions();

                    options.AddArguments("--disable-extensions --disable-extensions-file-access-check --disable-extensions-http-throttling --disable-infobars --enable-automation --start-maximized");
                    options.AddUserProfilePreference("credentials_enable_service", false);
                    options.AddUserProfilePreference("profile.password_manager_enabled", false);
                    Driver.driver = new ChromeDriver(options);
                    break;

            }
            if (KeyResource.IsLogin == "true")
            {
                Login loginobj = new Login();
                loginobj.LoginSuccessfull();
            }
            else
            {
                Register obj = new Register();
                obj.Navigateregister();
            }
            extent = new ExtentReports(ReportPath, true, DisplayOrder.OldestFirst);
            extent.LoadConfig(KeyResource.ReportXMLPath);
        }

        [Given(@"Navigate to the login page")]
        public void GivenNavigateToTheLoginPage()
        {
           
        }

        [Given(@"I have enter '(.*)' and  '(.*)'")]
        public void GivenIHaveEnterAnd(string Username, string Password)
        {
            //Driver.driver.FindElement(By.XPath("//input[@id='UserName']")).SendKeys(Username);
            //Thread.Sleep(2000);

            //Driver.driver.FindElement(By.Id("Password")).SendKeys(Password);
            //Thread.Sleep(2000);
        }

        [Given(@"I click on Login button")]
        public void GivenIClickOnLoginButton()
        {
           
            //Driver.driver.FindElement(By.XPath("//button[text()='Login']")).Click();
            //Thread.Sleep(2000);

           

        }


        [Given(@"I have logged into key application page")]
        public void GivenIHaveLoggedIntoKeyApplicationPage()
        {

            test = extent.StartTest("Validating Dashboard");
            //Adding screenshot in extendReport
            string screenShotPath = CommonMethods.SaveScreenShotClass.SaveScreenshot(Driver.driver, "Login");
            Base.test.Log(LogStatus.Pass, "Snapshot below: " + Base.test.AddScreenCapture(screenShotPath));


        }
        [Then(@"I should see property dashboard page")]
        public void ThenIShouldSeePropertyDashboardPage()
        {
            //Creating object for property class 
            test = extent.StartTest("Clicking Owner");
            Property proObj = new Property();
            proObj.OwnerDashboard();

            //Adding screenshot in extendReport
            string screenShotPath = CommonMethods.SaveScreenShotClass.SaveScreenshot(Driver.driver, "Owner");
            Base.test.Log(LogStatus.Pass, "Snapshot below: " + Base.test.AddScreenCapture(screenShotPath));

                  
        }

        [Then(@"I click Add Tenant link on application")]
        public void ThenIClickAddTenantLinkOnApplication()
        {
            test = extent.StartTest("Search property");
            //Search property
            Driver.driver.FindElement(By.XPath("//input[@id='searchId']")).SendKeys("available for rent");
            Thread.Sleep(2000);
            // Click  Search button
            Driver.driver.FindElement(By.XPath("//input[@id='searchId']//following::button")).Click();
            Thread.Sleep(2000);

            //Adding screenshot in extendReport
            string screenShotPath = CommonMethods.SaveScreenShotClass.SaveScreenshot(Driver.driver, "Search property");
            Base.test.Log(LogStatus.Pass, "Snapshot below: " + Base.test.AddScreenCapture(screenShotPath));

            //clicking on Add Tenant 
            Driver.driver.FindElement(By.XPath("//div[@class='panel-body property-list-wrapper']/div[2]/div[2]/div[2]/div/a[1]")).Click();
            Thread.Sleep(2000);
            test = extent.StartTest("Click Tenant");
            //Adding screenshot in extendReport
            string screenShotPath1 = CommonMethods.SaveScreenShotClass.SaveScreenshot(Driver.driver, "Clicking Tenant");
            Base.test.Log(LogStatus.Pass, "Snapshot below: " + Base.test.AddScreenCapture(screenShotPath1));
            

        }

        [When(@"I fill mandatory details on the add tenant forms")]
        public void WhenIFillMandatoryDetailsOnTheAddTenantForms(Table table)
        {
            Tenant details = table.CreateInstance<Tenant>();
           var TenantDetails = Tenant.ToDictionary(table);
                 
            //Enter tenant email
            Driver.driver.FindElement(By.XPath("//*[@id='BasicDetail']/div[2]/div[1]/div/input")).SendKeys(TenantDetails["TenantEmail"]);
            Thread.Sleep(2000);

            //Scroll a page up
            IJavaScriptExecutor jss = (IJavaScriptExecutor)Driver.driver;
           jss.ExecuteScript("window.scrollTo(0, 200);");

            //Enter First Name
            // jss.ExecuteScript("document.getElementById('"your button id"').focus()")
           Driver.driver.FindElement(By.XPath("//*[@id='BasicDetail']/div[3]/div[1]/div/input")).Clear();
           Thread.Sleep(2000);
            Driver.driver.FindElement(By.XPath("//*[@id='BasicDetail']/div[3]/div[1]/div/input")).SendKeys(TenantDetails["FirstName"]);
            Thread.Sleep(2000);


            //Enter Last Name
            // jss.ExecuteScript("document.getElementById('"your button id"').focus()")
           // Driver.driver.FindElement(By.XPath("//fieldset[@id='BasicDetail']//div[3]/div[2]")).SendKeys(Keys.Delete);
           //Thread.Sleep(2000);
           // Driver.driver.FindElement(By.XPath("//fieldset[@id='BasicDetail']//div[3]/div[2]")).SendKeys(TenantDetails["LastName"]);
           // Thread.Sleep(2000);

            // cannot focus element
            Actions actions = new Actions(Driver.driver);
            actions.MoveToElement(Driver.driver.FindElement(By.XPath("//fieldset[@id='BasicDetail']//div[3]/div[2]")));
            actions.Click();
            actions.SendKeys(TenantDetails["LastName"]);
            actions.Build().Perform();
            Thread.Sleep(2000);

            //Rent start date
            Driver.driver.FindElement(By.XPath("//*[@id='BasicDetail']/div[4]/div[1]/div/input")).SendKeys(TenantDetails["RentStartDate"]);
            Thread.Sleep(2000);

            //Rentamount
            Driver.driver.FindElement(By.XPath("//*[@id='BasicDetail']/div[5]/div[1]/div/input")).SendKeys(TenantDetails["RentAmount"]);
            Thread.Sleep(2000);

            //paymentdate
            Driver.driver.FindElement(By.XPath("//*[@id='BasicDetail']/div[6]/div[1]/div/input")).SendKeys(TenantDetails["PaymentSDate"]);
            Thread.Sleep(2000);

            test = extent.StartTest("Enter all the data here");
            //Adding screenshot in extendReport
            string screenShotPath2 = CommonMethods.SaveScreenShotClass.SaveScreenshot(Driver.driver, "Filling data");
            Base.test.Log(LogStatus.Pass, "Snapshot below: " + Base.test.AddScreenCapture(screenShotPath2));

        }

        [When(@"I click the NEXT button")]
        public void WhenIClickTheNEXTButton()
        {
            Driver.driver.FindElement(By.XPath("//input[@class='btn btn-success']")).Click();
            Thread.Sleep(2000);
        }

        [Then(@"I should see all the details should saved and Liabilities detail page opened")]
        public void ThenIShouldSeeAllTheDetailsShouldSavedAndLiabilitiesDetailPageOpened()
        {
            //Screenshot
           // SaveScreenShotClass.SaveScreenshot(Driver.driver, "Tenant and property");
             //Report
          //  Global.Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Data saved sucessfully");
            test = extent.StartTest("Data saved");

            //Adding screenshot in extendReport
            string screenShotPath2 = CommonMethods.SaveScreenShotClass.SaveScreenshot(Driver.driver, "Filling data");
            Base.test.Log(LogStatus.Pass, "Snapshot below: " + Base.test.AddScreenCapture(screenShotPath2));

        }

        [When(@"I click on Add New Liability button")]
        public void WhenIClickOnAddNewLiabilityButton()
        {
            Driver.driver.FindElement(By.XPath("//fieldset[@id='LiabilityDetail']/div/div//a")).Click();
            Thread.Sleep(2000);
            test = extent.StartTest("Clicking Add Liability");

            //Adding screenshot in extendReport
            string screenShotPath2 = CommonMethods.SaveScreenShotClass.SaveScreenshot(Driver.driver, "clicking add liability");
            Base.test.Log(LogStatus.Pass, "Snapshot below: " + Base.test.AddScreenCapture(screenShotPath2));
        }

        [When(@"I have enter amount on add new liability application")]
        public void WhenIHaveEnterAmountOnAddNewLiabilityApplication()
        {
            Driver.driver.FindElement(By.XPath("//table[@class='table-financial table-properties property-projections table']/tbody/tr/td[2]/input")).SendKeys("3500");
            Thread.Sleep(2000);
        }


        [When(@"I click on Next button")]
        public void WhenIClickOnNextButton()
        {
            Driver.driver.FindElement(By.XPath("//div[@class='col-sm-12 text-center']/button[text()='Next']")).Click();
            Thread.Sleep(2000); 
        }

        [Then(@"I should see all the details saved and page redirected to summary page\.")]
        public void ThenIShouldSeeAllTheDetailsSavedAndPageRedirectedToSummaryPage_()
        {
            //ScenarioContext.Current.Pending();
        }

        [When(@"I click on submit button on summary page")]
        public void WhenIClickOnSubmitButtonOnSummaryPage()
        {
            Driver.driver.FindElement(By.XPath("//div[@class='col-sm-12 text-center']/button[text()='Submit']")).Click();
            Thread.Sleep(2000);

            test = extent.StartTest("Tenant added successfully");

            //Adding screenshot in extendReport
            string screenShotPath2 = CommonMethods.SaveScreenShotClass.SaveScreenshot(Driver.driver, "Tenant added successfully");
            Base.test.Log(LogStatus.Pass, "Snapshot below: " + Base.test.AddScreenCapture(screenShotPath2));

        }

        [Then(@"I should see all data should be saved and application redirect to properties page\.")]
        public void ThenIShouldSeeAllDataShouldBeSavedAndApplicationRedirectToPropertiesPage_()
        {
            test = extent.StartTest("Tenant added successfully");
        }

        [AfterScenario]

        public void AfterScenario()
        {
            // Screenshot
          //  String img = SaveScreenShotClass.SaveScreenshot(Driver.driver, "Report");//AddScreenCapture(@"E:\Dropbox\VisualStudio\Projects\Beehive\TestReports\ScreenShots\");
           // test.Log(LogStatus.Info, "Image example: " + img);
            // end test. (Reports)
            extent.EndTest(test);
            // calling Flush writes everything to the log file (Reports)
            extent.Flush();
            // Close the driver :)            
            Driver.driver.Close();
        }


    }
}
