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
    class LoginPage : BasePage
    {

        private static readonly String loginurl = "https://rcp:C0mmun!ty@myrcpuat.rcplondon.ac.uk/";
        //FirefoxProfile profile = new FirefoxProfile();
        //private IWebDriver driver;
               
        public LoginPage(IWebDriver driver) : base(driver, loginurl)
        {
        }

        public void GoToLoginPage(string loginurl)
        {
          GoToSite();
        }

        public void enterUsername (string username)
        {
               IWebElement usernameField = WebBrowser.Current.FindElement(By.Name("name"));
               usernameField.Clear();
               usernameField.SendKeys(username);
         }

        public void enterPassword(string password)
        {

            IWebElement enterPassword = WebBrowser.Current.FindElement(By.Name("pass"));
                enterPassword.Clear();
                enterPassword.SendKeys(password);
        }

        public void ClickLogin()
        {
            IWebElement loginButton = WebBrowser.Current.FindElement(By.CssSelector(".btn-primary")); // find the login button
            loginButton.Click(); // click on the login button
           // WebDriverWait wait = new WebDriverWait(WebBrowser.Current, TimeSpan.FromSeconds(5));
           // IWebElement title = wait.Until<IWebElement>((d) =>
           // {
            //    return d.FindElement(By.LinkText("have you forgotten your password?"));
           // });
        }

        public void ClickLogout()
        {
            IWebElement logoutButton = WebBrowser.Current.FindElement(By.Id("logout-link")); // find the login button
            logoutButton.Click(); // click on the logout button
        }

        public void ClickUpdateDetails()
        {
           // IWebElement updateDetailsButton = WebBrowser.Current.FindElement(By.CssSelector("btn btn-default")); // find the Update my details button
            IWebElement updateDetailsButton = WebBrowser.Current.FindElement(By.ClassName("btn-default")); // find the Update my details button
            updateDetailsButton.Click(); // click on update details button
            //WebDriverWait wait = new WebDriverWait(WebBrowser.Current, TimeSpan.FromSeconds(5));
            //IWebElement title = wait.Until<IWebElement>((d) =>
            // {
              //  return d.FindElement(By.LinkText("have you forgotten your password?"));
             //});
        }
       
    }
}
