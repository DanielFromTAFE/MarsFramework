using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsFramework.Pages;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;


namespace MarsFramework
{
    public class Program
    {
        [TestFixture]
        [Category("Sprint1")]
        class Tenant : Global.Base
        {

            [Test]
            public void UserAccount()
            {
                // Creates a toggle for the given test, adds all log events under it    
               test = extent.StartTest("Search for a Property");

                // Create an class and object to call the method
               Profile obj = new Profile();
               obj.EditProfile();
               
            }
            [Test]
            public void CreatNewSkill()
            {
                // Create Share Skills
                ShareSkills obj = new ShareSkills();
                obj.AddNewSkill();
            }
           
        }
    }
}