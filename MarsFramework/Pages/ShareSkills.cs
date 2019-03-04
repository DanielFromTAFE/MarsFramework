using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using MarsFramework.Global;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using System.IO;
using MarsFramework.Config;


namespace MarsFramework.Pages
{
    class ShareSkills
    {
    
        public ShareSkills()
        {
            OpenQA.Selenium.Support.PageObjects.PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }

        #region Initialize Elements
      /*  [FindsBy(How = How.XPath, Using = "//*[@id='account - profile - section']/div/section[1]/div/a[1]")]
        public IWebElement Dashboard { get; set; }

        [FindsBy(How = How.ClassName, Using = "item active")]
        public IWebElement Skills { get; set; }*/


        //[FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/section[1]/div/div[2]/a")]
        [FindsBy(How = How.CssSelector, Using = "div.ui:nth-child(1) div:nth-child(1) section.nav-secondary:nth-child(2) div.ui.eight.item.menu div.right.item:nth-child(5) > a.ui.basic.green.button")]
        public IWebElement ShareSkill { get; set; }

        
        // Title
        [FindsBy(How = How.Name, Using = "title")]
        public IWebElement Title { get; set; }


        // Description

        [FindsBy(How = How.Name, Using = "description")]
        public IWebElement Description { get; set; }

        // Select Category

        [FindsBy(How = How.Name, Using = "categoryId")]
        public IWebElement Category { get; set; }

        // Select Graphics & Design

        [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(3) div.twelve.wide.column div.fields div.five.wide.field:nth-child(1) select.ui.fluid.dropdown > option:nth-child(2)")]
        public IWebElement GraphicsDesign { get; set; }


        //Select SubCategory - Logo Design
        [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(3) div.twelve.wide.column div.fields div.five.wide.field:nth-child(2) div.fields:nth-child(1) > select.ui.fluid.dropdown")]
        public IWebElement SubCategory { get; set; }

        //Select SubCategory - Logo Design
        [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(3) div.twelve.wide.column div.fields div.five.wide.field:nth-child(2) div.fields:nth-child(1) select.ui.fluid.dropdown > option:nth-child(2)")]
        public IWebElement LogoDesign { get; set; }


        //Select Tag Names
        [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(4) div.twelve.wide.column div.form-wrapper.field div.ReactTags__tags div.ReactTags__selected div.ReactTags__tagInput > input.ReactTags__tagInputField")]
        public IWebElement Tag { get; set; }

        //Select Service Type -Hourly Basis
        [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(5) div.twelve.wide.column div.inline.fields div.field:nth-child(1) div.ui.radio.checkbox > label:nth-child(2)")]
        public IWebElement ServiceTypeHourly { get; set; }

        //Select Service Type -One-off
        [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(5) div.twelve.wide.column div.inline.fields div.field:nth-child(1) div.ui.radio.checkbox > label:nth-child(2)")]
        public IWebElement ServiceTypeOnOff { get; set; }

        //Select Location Type - Onsite
        [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(6) div.twelve.wide.column div.inline.fields div.field:nth-child(1) div.ui.radio.checkbox > label:nth-child(2)")]
        public IWebElement LocationTypeOnsite { get; set; }

        //Select Location Type - Onsite
        [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(6) div.twelve.wide.column div.inline.fields div.field:nth-child(2) div.ui.radio.checkbox > input:nth-child(1)")]
        public IWebElement LocationTypeOnline { get; set; }

        //Avilable Days -Start Date
        [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(7) div.twelve.wide.column div.form-wrapper div.fields:nth-child(1) div.five.wide.field:nth-child(2) > input:nth-child(1)")]
        public IWebElement StartDate { get; set; }

        //Avilable Days -End Date
        [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(7) div.twelve.wide.column div.form-wrapper div.fields:nth-child(1) div.five.wide.field:nth-child(4) > input:nth-child(1)")]
        public IWebElement EndDate { get; set; }

        //Skill Trade - Skill Exchange
        [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(8) div.twelve.wide.column:nth-child(2) div.inline.fields div.field:nth-child(1) div.ui.radio.checkbox > label:nth-child(2)")]
        public IWebElement SkillExchange { get; set; }

        // Skill Exchange - Required Skills
        [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(8) div.twelve.wide.column:nth-child(4) div.field div.form-wrapper div.ReactTags__tags div.ReactTags__selected div.ReactTags__tagInput > input.ReactTags__tagInputField")]
        public IWebElement RequiredSkills { get; set; }

        //Skill Trade - Credit
        [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(8) div.twelve.wide.column:nth-child(2) div.inline.fields div.field:nth-child(2) div.ui.radio.checkbox > label:nth-child(2)")]
        public IWebElement Credit { get; set; }


        //Credit - Enter Amount
        [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(8) div.ten.wide.column:nth-child(4) div:nth-child(1) div.ui.right.labeled.input > input:nth-child(2)")]
        public IWebElement CreditAmount { get; set; }

        // Status Active 
        [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(10) div.twelve.wide.column div.inline.fields div.field:nth-child(1) div.ui.radio.checkbox > label:nth-child(2)")]
        public IWebElement StatusActive { get; set; }

        // Status Hidden 
        [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(10) div.twelve.wide.column div.inline.fields div.field:nth-child(2) div.ui.radio.checkbox > label:nth-child(2)")]
        public IWebElement StatusHidden { get; set; }

        // Work Sample 
        [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(9) div.row div.twelve.wide.column div:nth-child(1) label.worksamples-file:nth-child(1) div.ui.grid span:nth-child(1) > i.huge.plus.circle.icon.padding-25")]
        public IWebElement WorkSample { get; set; }

        // Save Share Skills
        [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.ui.vertically.padded.right.aligned.grid:nth-child(11) div.sixteen.wide.column > input.ui.teal.button:nth-child(1)")]
        public IWebElement SaveShareSkills { get; set; }

        // Cancel Share Skills
        [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.ui.vertically.padded.right.aligned.grid:nth-child(11) div.sixteen.wide.column > input.ui.teal.button:nth-child(1)")]
        public IWebElement CancelShareSkills { get; set; }

        #endregion

        #region Add new Skill
        public void AddNewSkill()
        {
            
            System.Threading.Thread.Sleep(2000);
            #region Navigate to Share Skills Page
            // Click on Share Skills Page
            ShareSkill.Click();
            System.Threading.Thread.Sleep(1500);
            //Populate the excel data
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "ShareSkills");

            #endregion


            #region Enter Title 

            //Enter the data in Title textbox
            Title.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "title"));

            #endregion

            #region Enter Description

            //Enter the data in Description textbox
            Description.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "EnterDescription"));


            #endregion

            #region Category Drop Down

            // Click on Category Dropdown
            Category.Click();


            // Select Category from Category Drop Down
            var SelectElement = new SelectElement(Category);
            SelectElement.SelectByText((GlobalDefinitions.ExcelLib.ReadData(2, "category")));
         
            // Click on Sub-Category Dropdown
            SubCategory.Click();

            //Select Sub-Category from the Drop Down
            var SelectElement1 = new SelectElement(SubCategory);
            SelectElement1.SelectByText((GlobalDefinitions.ExcelLib.ReadData(2, "subcategory")));
            #endregion

            #region Tags
            // Eneter Tag
            Tag.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2,"TagName"));
            Tag.SendKeys(Keys.Enter);

            #endregion

            #region Service Type Selection

            // Service Type Selection
                     
            if (GlobalDefinitions.ExcelLib.ReadData(2, "ServiceType") == "Hourly basis service")
            {
                ServiceTypeHourly.Click();
            }
            else if (GlobalDefinitions.ExcelLib.ReadData(2,"ServiceType") == "One-off service")
            {
                ServiceTypeOnOff.Click();
            }
            #endregion

            #region Select Location Type
            // Location Type Selection
          
            if (GlobalDefinitions.ExcelLib.ReadData(2, "SelectLocationType") == "On-site")
            {
                LocationTypeOnsite.Click();
            }
            else if (GlobalDefinitions.ExcelLib.ReadData(2, "SelectLocationType") == "Online")
            {
                LocationTypeOnline.Click();
            }
            #endregion

            #region Select Available Dates from Calendar
            // Select Start Date
            StartDate.Click();
            // Select End Date
            EndDate.Click();
            #endregion
                       

            #region Select Skill Trade
            // Select Skill Trade

            if (GlobalDefinitions.ExcelLib.ReadData(2, "SelectSkillTrade") == "Skill-exchange")
            {
                
                RequiredSkills.Click();
                RequiredSkills.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "ExchangeSkill"));
                RequiredSkills.SendKeys(Keys.Enter);

            }
            else if (GlobalDefinitions.ExcelLib.ReadData(2, "SelectSkillTrade") == "Credit")
            {
                
                CreditAmount.Click();
                CreditAmount.SendKeys(Global.GlobalDefinitions.ExcelLib.ReadData(2, "AmountInExchange"));
                CreditAmount.SendKeys(Keys.Enter);
            }
            #endregion

            #region Select User Status
            // Select User Status
            
            if (GlobalDefinitions.ExcelLib.ReadData(2, "UserStatus") == "Active")
            {
                StatusActive.Click();
            }
            else if (GlobalDefinitions.ExcelLib.ReadData(2, "UserStatus") == "Hidden")
            {
                StatusHidden.Click();
            }
            #endregion


            #region Add Work Sample
            // Add Work Sample
            Thread.Sleep(2000);
            //Work Sample upload button path
            IWebElement upload = GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='selectFile']"));
            
            // Uploading File path
            var GetCurrentDirectory = Directory.GetCurrentDirectory();
            String path = GetCurrentDirectory + @"\MarsFramework\Upload Files\Samplework.txt";
            upload.SendKeys(path);




            #endregion

            #region Save / Cancel Skill
            // Save or Cancel New Skill

            if (Global.GlobalDefinitions.ExcelLib.ReadData(2, "SaveOrCancel") == "Save")
            {
                SaveShareSkills.Click();
            }
            else if (Global.GlobalDefinitions.ExcelLib.ReadData(2, "SaveOrCancel") == "Cancel")
            {
                CancelShareSkills.Click();
            }
            #endregion


            #region Check whether New  skill created sucessfully 

            string ShareSkillSucess = Global.GlobalDefinitions.driver.FindElement(By.LinkText("Manage Listings")).Text;

            if (ShareSkillSucess == "Manage Listings")
            {
                Global.Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Shared Skill Successful");
            }
            else
                Global.Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Share Skill Unsuccessful");
            #endregion
        }
        #endregion
    }
}
