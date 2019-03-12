using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsFramework.Pages;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using static MarsFramework.Global.GlobalDefinitions;
using MarsFramework.Global;
using RelevantCodes.ExtentReports;
using OpenQA.Selenium;



namespace MarsFramework
{
    [TestFixture]
    [Parallelizable]
    [Category("Sprint1")]
    public class Program_FirefoxBrowser : Base

    {
        public Program_FirefoxBrowser() : base(BrowserType.Firefox)
        {
        }
        
        [Test]
        public void CreatNewSkill_FirefoxBrowser()
        {
            
            //Create Extent Report
            test = extent.StartTest("Share Skills");
            // Create Share Skills
            ShareSkills obj = new ShareSkills();
            obj.AddNewSkill();
            
        }

            
        

    }

    [TestFixture]
    [Parallelizable]
    [Category("Sprint1")]
    class Program_ChromeBrowser : Base

    {
        public Program_ChromeBrowser() : base(BrowserType.Chrome)
        {
        }


        [Test]
        public void CreatNewSkill_ChromeBrowser()
        {
            //Create Extent Report
            test = extent.StartTest("Share Skills");
            // Create Share Skills
            ShareSkills obj1 = new ShareSkills();
            obj1.AddNewSkill();
        }

    }

}

    
