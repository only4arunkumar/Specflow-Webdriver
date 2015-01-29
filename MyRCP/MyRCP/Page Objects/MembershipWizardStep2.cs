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
    class MembershipWizardStep2: BasePage


    {


         //Contructor to re-use the driver
        public MembershipWizardStep2(IWebDriver driver): base(driver)
        {


        }


        public void ClickNext()
        {

            IWebElement nextStep = WebBrowser.Current.FindElement(By.Id("StepNextButton")); // find the login button
            nextStep.Click(); // click the next button
        
        }

        public void validateStep2ErrorMessage()
        {
            //Check that the correct error message is displayed
            Assert.IsTrue((WebBrowser.Current.FindElement(By.CssSelector(".element-invisible")).Text.Equals("Error message")));
        }


    }
}
