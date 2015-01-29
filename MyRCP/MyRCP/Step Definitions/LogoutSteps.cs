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
    public class LogoutSteps
    {
        [Given(@"I am succesfully logged-in to the ""(.*)"" page")]
        public void GivenIAmSuccesfullyLogged_InToThePage(string p0)
        {
            var login = new LoginPage(WebBrowser.Current);
            login.GoToLoginPage("https://rcp:C0mmun!ty@myrcpuat.rcplondon.ac.uk/");

            login.enterUsername("10113@rcplondon.ac.uk");

            login.enterPassword("password");

            login.ClickLogin();
        }
        
        [When(@"I press logout")]
        public void WhenIPressLogout()
        {
            var logout = new LoginPage(WebBrowser.Current);
            logout.ClickLogout();
        }
        
        [Then(@"I am redirected to the Rcp London home page")]
        public void ThenIAmRedirectedToTheRcpLondonHomePage()
        {
            var LogoutSRP = new LoginResultPage(WebBrowser.Current);
            LogoutSRP.ValidateSuccesfulLogout();
            
        }
    }
}
