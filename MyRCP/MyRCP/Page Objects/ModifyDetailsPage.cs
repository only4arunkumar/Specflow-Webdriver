using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;
using System.Threading;
using NUnit.Framework;
using MyRCP.Helpers;
using System.Diagnostics;
using MyRCP.Page_Objects;


namespace MyRCP.Page_Objects
{
    class ModifyDetailsPage : BasePage 
    {
         //Contructor to re-use the driver
        public ModifyDetailsPage(IWebDriver driver) : base(driver)
        {

        }

        public void enterFirstName(string fname)
        {
            IWebElement fnameField = WebBrowser.Current.FindElement(By.Name("field_firstname[und][0][value]"));
            fnameField.Clear();
            fnameField.SendKeys(fname);
        }

        //TODO build the methods for all of the modifiable elements in the page. 

        public void ClickSaveYourDetails()
        {
            IWebElement saveChanges = WebBrowser.Current.FindElement(By.CssSelector("button.btn-lg")); // find the Save your details button

          
            //Check how long it takes to load the MYRCP page.
            Timed.Execute(() =>
                {
                    saveChanges.Click();

                },
               (long millis) =>
               {

                   var updatedetailsSRP = new GenericResultsPage(WebBrowser.Current);
                   updatedetailsSRP.ValidatePageLoadTime(millis, 16000);
                               
               });
                     
        }
    }
}
