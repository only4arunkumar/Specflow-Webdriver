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

namespace MyRCP.Page_Objects
{
    class RegistrationPage : BasePage
    {

        private static readonly String loginurl = "https://rcp:C0mmun!ty@myrcpuat.rcplondon.ac.uk/user/register";

        public RegistrationPage(IWebDriver driver): base(driver, loginurl)
        {
        }

        public void GoToRegistrationPage(string loginurl)
        {
            GoToSite();
        }

        public void enterTitle(string title)
        {
            IWebElement titleField = WebBrowser.Current.FindElement(By.Id("edit-field-user-title-und"));
          //  titleField.Clear();
            titleField.SendKeys(title);
        }

        public void enterFirstName(string fname)
        {
            IWebElement fnameField = WebBrowser.Current.FindElement(By.Id("edit-field-firstname-und-0-value"));
          //  fnameField.Clear();
            fnameField.SendKeys(fname);
        }

        public void enterLastName(string lname)
        {
            IWebElement lnameField = WebBrowser.Current.FindElement(By.Id("edit-field-lastname-und-0-value"));
           // lnameField.Clear();
            lnameField.SendKeys(lname);
        }

        public void enterEmail(string email)
        {
            IWebElement emailField = WebBrowser.Current.FindElement(By.Id("edit-mail"));
           // emailField.Clear();
            emailField.SendKeys(email);
        }

        public void enterPassword(string password)
        {
            IWebElement passwordField = WebBrowser.Current.FindElement(By.Id("edit-pass-pass1"));
        //    passwordField.Clear();
            passwordField.SendKeys(password);
        }

        public void confirmPassword(string password)
        {
            IWebElement cnfpasswordField = WebBrowser.Current.FindElement(By.Id("edit-pass-pass2"));
          //  cnfpasswordField.Clear();
            cnfpasswordField.SendKeys(password);
        }




        public void ClickCreateAccount()
        {
            IWebElement createAccount = WebBrowser.Current.FindElement(By.CssSelector(".btn-primary")); // find the login button
            createAccount.Click(); // click on the login button
           // WebDriverWait wait = new WebDriverWait(WebBrowser.Current, TimeSpan.FromSeconds(5));
            // IWebElement title = wait.Until<IWebElement>((d) =>
            // {
            //    return d.FindElement(By.LinkText("have you forgotten your password?"));
            // });
        }


        internal void enterRcpCode(int rcpCode)
        {
            IWebElement rcpCodeField = WebBrowser.Current.FindElement(By.Id("edit-field-rcp-code-number-und-0-value"));
            rcpCodeField.SendKeys(rcpCode.ToString());
        }

    }
}
