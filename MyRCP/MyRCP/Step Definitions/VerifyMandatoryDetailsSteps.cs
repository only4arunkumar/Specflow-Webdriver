using System;
using TechTalk.SpecFlow;
using MyRCP.Page_Objects;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using NUnit.Framework;
using MyRCP.Helpers;


namespace MyRCP
{
    [Binding]
    public class VerifyMandatoryDetailsSteps
    {

        [Given(@"I am logged in to the myRCP page")]
        public void GivenIAmLoggedInToTheMyRCPPage()
        {
            var login = new LoginPage(WebBrowser.Current);
            login.GoToLoginPage("https://rcp:C0mmun!ty@myrcpuat.rcplondon.ac.uk/");

            var login1 = new LoginPage(WebBrowser.Current);
            login1.enterUsername("RCPTest3+181@gmail.com");

            var login2 = new LoginPage(WebBrowser.Current);
            login2.enterPassword("password");

            var login3 = new LoginPage(WebBrowser.Current);
            login3.ClickLogin();
        }
        
        [Given(@"I am applying for affiliate membership")]
        public void GivenIAmApplyingForAffiliateMembership()
        {
            var page = new DashboardPage(WebBrowser.Current);
            page.clickContinueApplication();
          
        }       
        
        [When(@"I press Next on Step (.*) of the membership wizard")]
        public void WhenIPressNextOnStepOfTheMembershipWizard(int p0)
        {
            var page = new MembershipWizardStep2(WebBrowser.Current);
            page.ClickNext();
        }
        
        [Then(@"I am prompted to enter an Address")]
        public void ThenIAmPromptedToEnterAnAddress()
        {
            var page = new MembershipWizardStep2(WebBrowser.Current);
            page.validateStep2ErrorMessage();
        }
    }
}
