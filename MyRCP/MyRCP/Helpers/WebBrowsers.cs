using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
namespace MyRCP.Helpers
{
    [Binding]
    public class WebBrowser
    {
        public static IWebDriver Current
        {
            get
            {
                if (!ScenarioContext.Current.ContainsKey("browser"))
                {

                    //string IE_DRIVER_PATH = @"C:\Projects\WebDrivers\IE"; 
                    //Select IE browser
                    //ScenarioContext.Current["browser"] = new InternetExplorerDriver(IE_DRIVER_PATH);

                    //Select Firefox browser
                    ScenarioContext.Current["browser"] = new FirefoxDriver();

                    //string CHROME_DRIVER_PATH = @"C:\Projects\WebDrivers\Chrome";  
                    

                    //Select Chrome browser
                  //  ScenarioContext.Current["browser"] = new ChromeDriver(CHROME_DRIVER_PATH);
                }
                return (IWebDriver)ScenarioContext.Current["browser"];
            }
        }

        [AfterScenario]
        public static void Close()
        {
            if (ScenarioContext.Current.ContainsKey("browser"))
            {
                Current.Dispose();
            }
        }
    }
}