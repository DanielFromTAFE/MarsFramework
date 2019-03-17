using MarsFramework.Global;
using MarsFramework.Pages;
using NUnit.Framework;



namespace MarsFramework
{
    [TestFixture(BrowserType.Firefox)]
    [TestFixture(BrowserType.Chrome)]
    [Parallelizable(ParallelScope.Fixtures)]
    [Category("Sprint1")]
    public class Program : Base

    {
        public Program(BrowserType browser) : base(browser)
        {
        }

        [Test]
        public void CreatNewSkill()
        {

            //Create Extent Report
            test = extent.StartTest("Share Skills");
            // Create Share Skills      
            ShareSkills obj = new ShareSkills(_driver);
            obj.AddNewSkill();

        }
    

    }
}


