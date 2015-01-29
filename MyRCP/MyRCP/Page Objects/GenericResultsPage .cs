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
    class GenericResultsPage : BasePage
    {

        //Contructor to re-use the driver
        public GenericResultsPage(IWebDriver driver)
            : base(driver)
        {

        }
        
        public void VaidateMainDashboardPage()
         {
            Assert.IsTrue((WebBrowser.Current.PageSource.Contains("My contact details")));
         }


        public void VaidateSavedDetails()
        {
            Assert.IsTrue((WebBrowser.Current.PageSource.Contains("The changes have been saved.")));
     
        }

        public void ValidatePageLoadTime(long millis, long maxExpectedTime)
        {

            //Convert milliseconds to seconds.


            if (millis > maxExpectedTime)
            {
                double seconds = TimeSpan.FromMilliseconds(maxExpectedTime).TotalSeconds;
                Assert.Fail("Page is taking longer than " + seconds.ToString() + " seconds to load");

            }
        
        }       

    }
}
