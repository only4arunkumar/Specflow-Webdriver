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
    public class LoginSteps
    {
        [Given(@"I have navigated to the myrcp login page")]
        public void GivenIHaveNavigatedToTheMyrcpLoginPage()
        {
            var login = new LoginPage(WebBrowser.Current);
            login.GoToLoginPage("https://rcp:C0mmun!ty@myrcpuat.rcplondon.ac.uk/");
        }
        
        [Given(@"I have entered an invalid email address")]
        public void GivenIHaveEnteredAnInvalidEmailAddress()
        {
            var login = new LoginPage(WebBrowser.Current);
            login.enterUsername("invalidEmail@error.com");
        }
        
        [Given(@"I have entered a valid password")]
        public void GivenIHaveEnteredAValidPassword()
        {
            var login = new LoginPage(WebBrowser.Current);
            login.enterPassword("password");
        }

        [Given(@"I have entered a invalid password")]
        public void GivenIHaveEnteredAInvalidPassword()
        {
            var login = new LoginPage(WebBrowser.Current);
            login.enterPassword("passinv");
        }

        [Given(@"I have entered an invalid rcp code number")]
        public void GivenIHaveEnteredAnInvalidRcpCodeNumber()
        {
            var login = new LoginPage(WebBrowser.Current);
            login.enterUsername("1111111111");
        }
        
        [Given(@"I have entered a valid emailaddress")]
        public void GivenIHaveEnteredAValidEmailAddress()
        {
            var login = new LoginPage(WebBrowser.Current);
            login.enterUsername("10113@rcplondon.ac.uk");
        }
        
        [When(@"I press login")]
        public void WhenIPressLogin()
        {
            var login = new LoginPage(WebBrowser.Current);
            login.ClickLogin();
        }
        
        [Then(@"I get an invalid credentials message")]
        public void ThenIGetAnInvalidCredentialsMessage()
        {
            var LoginSRP = new LoginResultPage(WebBrowser.Current);
            LoginSRP.ValidateIncorrectCredentials();
        }
        
        [Then(@"I get a ""(.*)"" message on the top of the page")]
        public void ThenIGetAMessageOnTheTopOfThePage(string p0)
        {
            var LoginSRP = new LoginResultPage(WebBrowser.Current);
            LoginSRP.ValidateSuccesfulLogin();
        }
    }
}
