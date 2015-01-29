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
    class RegistrationResultsPage :BasePage 
    {

        //Contructor to re-use the driver
        public RegistrationResultsPage(IWebDriver driver) : base(driver)
        {

        }


        public void ValidateDuplicateContact()
        {
            //Check that the correct display message is what we are excpecting 
            Assert.IsTrue((WebBrowser.Current.PageSource.Contains("Unable to set up your account. Please contact RCP.")));
        }


        public void ValidateInvalidEmail()
        {
            //Check that the correct display message is what we are excpecting 
            Assert.IsTrue((WebBrowser.Current.PageSource.Contains("The e-mail address")) 
            && WebBrowser.Current.PageSource.Contains("is not valid"));
        }

        public void ValidateBlancEmail()
        {
            //Check that the correct display message is what we are excpecting 
            Assert.IsTrue((WebBrowser.Current.PageSource.Contains("E-mail address field is required."))); 
        }

               
        public void ValidateSuccesfulRegistration()
        {
            //Check that a message display message is what we are excpecting - This should indicate that user has been created but has not been approved yet  

            try
            {
                Assert.IsTrue((WebBrowser.Current.PageSource.Contains("A welcome message with further instructions has been sent to your e-mail address.")));
                
                //increment the user
                TestDataGlobals.IncrementLastUser();
            }

            catch (AssertionException)

            {
                throw;
            
            }
           
        }
       
    }
}
