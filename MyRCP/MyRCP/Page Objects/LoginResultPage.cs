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
    class LoginResultPage : BasePage
    {
        //Contructor to re-use the driver
        public LoginResultPage(IWebDriver driver) :base(driver)
        {
        }

        public void ValidateIncorrectCredentials()
        {
            //Check that the correct display message is what we are excepting 
            Assert.AreEqual("Have you forgotten your password?", WebBrowser.Current.FindElement(By.LinkText("Have you forgotten your password?")).Text);
        }

        public void ValidateSuccesfulLogin()
        {
            //Check that the Welcome Page is displayed 
             Assert.IsTrue((WebBrowser.Current.FindElement(By.CssSelector(".page-header")).Text.Equals("Welcome to MyRCP")));
        }

        public void ValidateSuccesfulLogout()
        {
            //Check that the Welcome Page is displayed 
            Assert.IsTrue (WebBrowser.Current.PageSource.Contains("Log in"));
           
        }

    }
}

