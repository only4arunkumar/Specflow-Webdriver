using System;
using TechTalk.SpecFlow;
using MyRCP.Page_Objects;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using NUnit.Framework;
using MyRCP.Helpers;

namespace MyRCP.Step_Definitions
{
    [Binding]
    public class LoginBadEmailSteps
    {
        [Given(@"I have navigated to the myrcp login page")]
        public void GivenIHaveNavigatedToTheMyrcpLoginPage()
        {
           var login = new LoginPage(WebBrowser.Current);
           login.GoToLoginPage("https://rcp:C0mmun!ty@myrcpuat.rcplondon.ac.uk/");
        }
        
        [Given(@"I have entered an invalid emailaddress")]
        public void GivenIHaveEnteredAnInvalidEmailaddress()
        {
            var login = new LoginPage(WebBrowser.Current);
            login.enterUsername("invalidEmail@error.com");
            //ScenarioContext.Current.Pending();
        }
        
        [Given(@"I have entered a valid password")]
        public void GivenIHaveEnteredAValidPassword()
        {
            //ScenarioContext.Current.Pending();
            var login = new LoginPage(WebBrowser.Current);
            login.enterPassword("password");
        }
        
        [When(@"I press login")]
        public void WhenIPressLogin()
        {
            var login = new LoginPage(WebBrowser.Current);
            login.ClickLogin();
        }
        
        [Then(@"the system should not allow me to login and warn me of an incorrect email")]
        public void ThenTheSystemShouldNotAllowMeToLoginAndWarnMeOfAnIncorrectEmail()
        {
            var LoginSRP = new LoginResultPage(WebBrowser.Current);
            LoginSRP.ValidateTest();
        }
    }
}
