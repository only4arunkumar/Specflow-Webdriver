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
    public class RegistrationSteps
    {
        [Given(@"I have navigated to the ""(.*)"" Registration page")]
        public void GivenIHaveNavigatedToTheRegistrationPage(string p0)
        {
             var registration = new RegistrationPage(WebBrowser.Current);
             registration.GoToRegistrationPage("https://rcp:C0mmun!ty@myrcpuat.rcplondon.ac.uk/user/register");
        }

        [Given(@"I fill in my RCP code with ""(.*)""")]
        public void GivenIFillInMyRCPCodeWith(int rcpCode)
        {
            var registration1 = new RegistrationPage(WebBrowser.Current);
            registration1.enterRcpCode(rcpCode);
        }

        [Given(@"I fill in my email address with ""(.*)""")]
        public void GivenIFillInMyEmailAddressWith(string emailAddress)
        {
            var registration1 = new RegistrationPage(WebBrowser.Current);
            registration1.enterEmail(emailAddress);
        }


        [Given(@"I have entered my details")]
        public void GivenIHaveEnteredMyDetails()
        {
            var registration1 = new RegistrationPage(WebBrowser.Current);
            registration1.enterTitle("DR");
            registration1.enterFirstName("TestFirstName");
            registration1.enterLastName("TestlastName");
            registration1.enterPassword("password");
            registration1.confirmPassword("password");

        }

        [Given(@"my email address is already stored")]
        public void GivenMyEmailAddressIsAlreadyStored()
        {
            var registration1 = new RegistrationPage(WebBrowser.Current);
            registration1.enterEmail("40993@rcplondon.ac.uk");
        }
        
        [When(@"I press Create new account")]
        public void WhenIPressCreateNewAccount()
        {
            var registration1 = new RegistrationPage(WebBrowser.Current);
            registration1.ClickCreateAccount();
        }
        
        [Then(@"I am warned that I was unable to set up my account")]
        public void ThenIAmWarnedThatIWasUnableToSetUpMyAccount()
        {
            var RegistrationSRP = new RegistrationResultsPage(WebBrowser.Current);
            RegistrationSRP.ValidateDuplicateContact();
        }


        // alternative path for invalid email address
        [Given(@"The email address entered is not valid")]
        public void GivenMyEmailAddressEnteredIsNotValid()
        {
            var registration1 = new RegistrationPage(WebBrowser.Current);
            registration1.enterEmail("test.com");

        }

        [Then(@"I am warned that I have entered an invalid email")]
        public void ThenIAmWarnedThatIHaveEnteredAnInvalidEmail()
        {
            var RegistrationSRP = new RegistrationResultsPage(WebBrowser.Current);
            RegistrationSRP.ValidateInvalidEmail();
        }

        // No password is entered 
        [Given(@"I have not entered an email")]
        public void GivenIHaveNotEnteredAPassword()
        {
           // Do nothing as wwe need to leave the email field blank
        }

        [Then(@"I am warned that the email is required")]
        public void ThenIAmWarnedThatThePasswordIsRequired()
        {
            var RegistrationSRP = new RegistrationResultsPage(WebBrowser.Current);
            RegistrationSRP.ValidateBlancEmail();
        }

        [Then(@"I am warned that the email address is already registered")]
        public void ThenIAmWarnedThatTheEmailAddressIsAlreadyRegistered()
        {
            var RegistrationSRP = new RegistrationResultsPage(WebBrowser.Current);
            RegistrationSRP.validateExistingEmail();
        }

        //Succesful login

        [Given(@"I fill in the following:")]
        public void GivenIFillInTheFollowing(Table table)
        {

            var registration1 = new RegistrationPage(WebBrowser.Current);
            //var nextUserNumberToAppend = TestDataGlobals.GetNextTestUser().ToString();
            Random rnd = new Random();
            int nextUserNumberToAppend = rnd.Next(1, 999999999);

            foreach (var row in table.Rows)
            {
                var title = row["Title"];
                registration1.enterTitle(title);

                var firstname = row["Firstname"];
                firstname += nextUserNumberToAppend;
                registration1.enterFirstName(firstname);

                var lastname = row["Lastname"];
                lastname += nextUserNumberToAppend;
                registration1.enterLastName(lastname);

                var emailaddress = row["E-mailaddress"];
                emailaddress += nextUserNumberToAppend + "@gmail.com";
                registration1.enterEmail(emailaddress);

                var password = row["Password"];
                registration1.enterPassword(password);

                var confirmPassword = row["Confirm Password"];
                registration1.confirmPassword(confirmPassword);
            }

        }

        [Then(@"A welcome email with further instuctions is sent")]
        public void ThenAWelcomeEmailWithFurtherInstuctionsIsSent()
        {
            var RegistrationSRP = new RegistrationResultsPage(WebBrowser.Current);
            RegistrationSRP.ValidateSuccesfulRegistration();
        }

    }
}
