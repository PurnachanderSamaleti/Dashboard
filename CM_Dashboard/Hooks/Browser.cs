using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System.Configuration;
using TechTalk.SpecFlow;
using WebDriverManager.DriverConfigs.Impl;

namespace CM_Dashboard.Hooks
{
    [Binding]
    public sealed class Browser
    {
        public IWebDriver driver;
        
        [BeforeScenario]
        [Obsolete]
        public void BeforeScenarioWithTag()
        {
            //Actions act = new Actions(driver);
            String browsername = ConfigurationManager.AppSettings["browser"];
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://sensor.test-cowmanager.com/company/company");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.Manage().Timeouts().PageLoad.Add(System.TimeSpan.FromSeconds(70));
            ScenarioContext.Current.Add("currentDriver", driver);
        }

        
        [AfterScenario]
        public void AfterScenario()
        {
            driver.Quit();
        }
    }
}