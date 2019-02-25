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
        class Mars : Global.Base
        {

            [Test]
            public void EditProfile()
            {
                // Creates a toggle for the given test, adds all log events under it    
            //   test = extent.StartTest("Edit Profile");


                // Create an class and object to call the method
               Profile obj = new Profile();
               obj.EditProfile();
               
            }
            [Test]
            public void CreatNewSkill()
            {
                //Create Extent Report
                test = extent.StartTest("Share Skills");
                // Create Share Skills
                ShareSkills obj = new ShareSkills();
                obj.AddNewSkill();
            }
           
        }
    }
}