using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using MyRCP.Helpers;

namespace MyRCP.Page_Objects
{
    class DashboardPage: BasePage
    {
        public DashboardPage(IWebDriver driver): base(driver)
        {

        }


        public void applyForMembership()
        {
            throw new NotImplementedException();   
        }



        internal void clickContinueApplication()
        {
            IWebElement continueApplication = WebBrowser.Current.FindElement(By.LinkText("Continue application")); // find the continue application button
            continueApplication.Click(); // click on the continue application button            
        }
    }
}
