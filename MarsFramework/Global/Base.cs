using MarsFramework.Config;
using MarsFramework.Pages;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using RelevantCodes.ExtentReports;
using System;
using System.IO;
using static MarsFramework.Global.GlobalDefinitions;

namespace MarsFramework.Global
{
    public enum BrowserType
    {
        Firefox,
        Chrome
    }
    [TestFixture]
    public class Base
    {
        private readonly BrowserType _BrowserType;
        public RemoteWebDriver _driver;
        public Base(BrowserType browser)
        {
            _BrowserType = browser;
        }
        #region To access Path from resource file / Dynamic paths

        // public static int Browser = Int32.Parse(MarsResource.Browser);

        // Excel path
        public static String ExcelPath = Directory.GetCurrentDirectory() + @"\MarsFramework\ExcelData\TestData.xlsx";

        // Path to Save Screenshots
        public static String ScreenshotPath = Directory.GetCurrentDirectory() + @"\MarsFramework\TestReports\Screenshots";

        // Report path
        public static String ReportPath = Directory.GetCurrentDirectory() + @"\MarsFramework\TestReports\MarsReports.html";

        // Report XML path
        public static String ReportXMLPath = Directory.GetCurrentDirectory() + @"\MarsFramework\Config\XMLFile.xml";

        #endregion

        #region reports
        public static ExtentTest test;
        public static ExtentReports extent;

        #endregion

        #region setup and tear down
        [SetUp]
        public void InititalizeTest()
        {

            // advisasble to read this documentation before proceeding http://extentreports.relevantcodes.com/net/

            ChooseBrowser(_BrowserType);


            void ChooseBrowser(BrowserType browserType)
            {
                if (browserType == BrowserType.Firefox)
                {
                    _driver = new FirefoxDriver();
                }
                else if (browserType == BrowserType.Chrome)
                {
                    _driver = new ChromeDriver();
                }

            }

            #region Initialise Reports

            extent = new ExtentReports(ReportPath, false, DisplayOrder.NewestFirst);
            extent.LoadConfig(ReportXMLPath);

            #endregion

            if (MarsResource.IsLogin == "true")
            {
                SignIn loginobj = new SignIn(_driver);
                loginobj.LoginSteps();
            }
            else
            {
                SignUp obj = new SignUp(_driver);
                obj.Register();
            }

        }


        [TearDown]
        public void TearDown()
        {

            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                // Screenshot
                String img = SaveScreenShotClass.SaveScreenshot(_driver, "Report");//AddScreenCapture(@"E:\Dropbox\VisualStudio\Projects\Beehive\TestReports\ScreenShots\");
                test.Log(LogStatus.Error, "Image example: " + img);
            }

            // end test. (Reports)
            extent.EndTest(test);
            // calling Flush writes everything to the log file (Reports)
            extent.Flush();
            // Close the driver :)            
            _driver.Close();
        }
        #endregion

    }
}