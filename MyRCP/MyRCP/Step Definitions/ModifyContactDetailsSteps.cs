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
    public class ModifyContactDetailsSteps
    {
        [Given(@"I have succesfully logged in to the myRCP page")]
        public void GivenIHaveSuccesfullyLoggedInToTheMyRCPPage()
        {
            var login = new LoginPage(WebBrowser.Current);
            login.GoToLoginPage("https://rcp:C0mmun!ty@myrcpuat.rcplondon.ac.uk/");

            var login1 = new LoginPage(WebBrowser.Current);
            login1.enterUsername("10113@rcplondon.ac.uk");

            var login2 = new LoginPage(WebBrowser.Current);
            login2.enterPassword("password");

            var login3 = new LoginPage(WebBrowser.Current);
            login3.ClickLogin();
        }
        
        [Given(@"I have pressed Update my details")]
        public void GivenIHavePressedUpdateMyDetails()
        {
            var login = new LoginPage(WebBrowser.Current);
            login.ClickUpdateDetails();
        }
        
        [Given(@"I modify my first name")]
        public void GivenIModifyMyFirstName()
        {
            var modify = new ModifyDetailsPage(WebBrowser.Current);
            modify.enterFirstName("fname101113Test12");
        }
        
        [When(@"I press Save your details")]
        public void WhenIPressSaveYourDetails()
        {
            var modify = new ModifyDetailsPage(WebBrowser.Current);
            modify.ClickSaveYourDetails();
        }
        
        [Then(@"I am redirected to the main dashboard")]
        public void ThenIAmRedirectedToTheMainDashboard() 
        {
            var updatedetailsSRP = new GenericResultsPage(WebBrowser.Current);
            updatedetailsSRP.VaidateMainDashboardPage();
        }
        
        [Then(@"I get a messages at the top of the page confirming the changes")]
        public void ThenIGetAMessagesAtTheTopOfThePageConfirmingTheChanges()
        {
            var updatedetailsSRP = new GenericResultsPage(WebBrowser.Current);
            updatedetailsSRP.VaidateSavedDetails();
        }
    }
}
