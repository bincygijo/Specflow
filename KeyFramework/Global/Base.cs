using System;
using KeyFramework.Config;
using KeyFramework.Global;
using RelevantCodes.ExtentReports;
using NUnit.Framework;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using static KeyFramework.Global.CommonMethods;
using KeyFramework.Pages;

namespace KeyFramework.Global
{

    //[TestFixture]
    public abstract class Base
    {

        #region To access Path from resource file

        public static int Browser = Int32.Parse(KeyResource.Browser);
        public static String ExcelPath = KeyResource.ExcelPath;
        public static string ScreenshotPath = KeyResource.ScreenShotPath;
        public static string ReportPath = KeyResource.ReportPath;
       // public static int RowCountBase = Int32.Parse(KeyResource.RowNum);
        public static int LoginBase = Int32.Parse(KeyResource.Login);
        //#endregion

        #region reports
        public static ExtentTest test;
        public static ExtentReports extent;

       
        #endregion

        #region setup and tear down
        [SetUp]
        public void Inititalize()
        {

            // advisasble to read this documentation before proceeding http://extentreports.relevantcodes.com/net/
            switch (Browser)
            {
                case 1:
                    Driver.driver = new FirefoxDriver();
                    break;
                case 2:

                    var options = new ChromeOptions();

                    options.AddArguments("--disable-extensions --disable-extensions-file-access-check --disable-extensions-http-throttling --disable-infobars --enable-automation --start-maximized");
                    options.AddUserProfilePreference("credentials_enable_service", false);
                    options.AddUserProfilePreference("profile.password_manager_enabled", false);
                    Driver.driver = new ChromeDriver(options);

                    //Driver.driver = new ChromeDriver();
                    //Driver.driver.Manage().Window.Maximize();
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


        [TearDown]
        public void TearDown()
        {
            // Screenshot
           // String img = SaveScreenShotClass.SaveScreenshot(Driver.driver, "Report");//AddScreenCapture(@"E:\Dropbox\VisualStudio\Projects\Beehive\TestReports\ScreenShots\");
          //  test.Log(LogStatus.Info, "Image example: " + img);
            // end test. (Reports)
            extent.EndTest(test);
            // calling Flush writes everything to the log file (Reports)
            extent.Flush();
            // Close the driver :)            
            //Driver.driver.Close();
            Driver.driver.Dispose();
        }
        #endregion
    }
}

#endregion