﻿using MarsFramework.Config;
using MarsFramework.Pages;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MarsFramework.Global.GlobalDefinitions;
using System.IO;
using OpenQA.Selenium;
using NUnit.Framework.Interfaces;
using static MarsFramework.Program;


namespace MarsFramework.Global
{
    class Base
    {
        #region To access Path from resource file / Dynamic paths

        public static int Browser = Int32.Parse(MarsResource.Browser);


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

        public void Inititalize()
        {

            // advisasble to read this documentation before proceeding http://extentreports.relevantcodes.com/net/


            switch (Browser)
            {

                case 1:
                    GlobalDefinitions.driver = new FirefoxDriver();
                    GlobalDefinitions.driver.Manage().Window.Maximize();
                    break;

                case 2:
                    GlobalDefinitions.driver = new ChromeDriver();
                    GlobalDefinitions.driver.Manage().Window.Maximize();
                    break;

            }

            #region Initialise Reports

            extent = new ExtentReports(ReportPath, false, DisplayOrder.NewestFirst);
            extent.LoadConfig(ReportXMLPath);

            #endregion

            if (MarsResource.IsLogin == "true")
            {
                SignIn loginobj = new SignIn();
                loginobj.LoginSteps();
            }
            else
            {
                SignUp obj = new SignUp();
                obj.register();
            }

        }


        [TearDown]
        public void TearDown()
        {

            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                // Screenshot
                String img = SaveScreenShotClass.SaveScreenshot(GlobalDefinitions.driver, "Report");//AddScreenCapture(@"E:\Dropbox\VisualStudio\Projects\Beehive\TestReports\ScreenShots\");
                test.Log(LogStatus.Error, "Image example: " + img);
            }

            // end test. (Reports)
            extent.EndTest(test);
            // calling Flush writes everything to the log file (Reports)
            extent.Flush();
            // Close the driver :)            
            GlobalDefinitions.driver.Close();
        }
        #endregion

    }
}