using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using TechTalk.SpecFlow;

namespace CM_Dashboard.StepDefinitions
{
    [Binding]
    public class DashboardStepDefinitions
    {
        public readonly IWebDriver driver;
        [Obsolete]
        public DashboardStepDefinitions()
        {
            driver = ScenarioContext.Current.Get<IWebDriver>("currentDriver");
        }
        [Given(@"Enter a valid username")]
        public void GivenEnterAValidUsername()
        {
            driver.FindElement(By.Id("signInName")).SendKeys("ariqt1");
        }

        [When(@"enter a valid password")]
        public void WhenEnterAValidPassword()
        {
            driver.FindElement(By.Id("password")).SendKeys("Ariqt@123");
        }

        [When(@"click on keep me sign in button")]
        public void WhenClickOnKeepMeSignInButton()
        {
            driver.FindElement(By.Id("rememberMe")).Click();
        }

        [Then(@"click on Sign in button")]
        public void ThenClickOnSignInButton()
        {
            driver.FindElement(By.Id("next")).Click();
        }
        [Given(@"Select the Simmental dairy company from the company list page")]
        public void GivenSelectTheSimmentalDairyCompanyFromTheCompanyListPage()
        {
            try
            {
                Actions act = new Actions(driver);
                driver.FindElement(By.Id("ag-152-input")).SendKeys("Simmental Dairy");
                act.MoveByOffset(0, 0).Click().Perform();
                act.DoubleClick(driver.FindElement(By.XPath("//div[@comp-id='190']"))).Build().Perform();

                //driver.FindElement(By.XPath("//div[@comp-id='190']")).Click();
                //Thread.Sleep(5000);
            }catch(Exception ex) {
                Console.WriteLine(ex.Message);
            }
        }

        [Given(@"Select the ""([^""]*)"" company from the company list page")]
        public void GivenSelectTheCompanyFromTheCompanyListPage(string dairy)
        {
                Actions act = new Actions(driver);
            //driver.FindElement(By.XPath("")
            Thread.Sleep(3000);
                driver.FindElement(By.Id("ag-152-input")).SendKeys(dairy);
                act.MoveByOffset(0, 0).Click().Perform();
                act.DoubleClick(driver.FindElement(By.XPath("//div[contains(text(),'"+dairy+"')]"))).Build().Perform();
            driver.FindElement(By.Id("e7905988-26a1-c231-59b6-037c8e4c93c6")).Click();
            driver.FindElement(By.Id("765b009c-0c37-5297-dd25-020b508525f8")).Click();
        }


        [When(@"Click on the Dashboar component")]
        public void WhenClickOnTheDashboarComponent()
        {
            driver.FindElement(By.Id("wm-menu-icon-Dashboard")).Click();
        }

        [When(@"Click on the select group dropdown")]
        public void WhenClickOnTheSelectGroupDropdown()
        {
            driver.FindElement(By.Id("downArrowIcon_header")).Click();
        }

        [When(@"Click on the Hyd East(.*) dropdown")]
        public void WhenClickOnTheHydEastDropdown(int p0)
        {
            driver.FindElement(By.Id("downArrowIcon_child_82")).Click();
        }

        [When(@"click on the Rescows group checkbox")]
        public void WhenClickOnTheRescowsGroupCheckbox()
        {
            driver.FindElement(By.Id("childGroup_65394")).Click();
        }

        [When(@"Click on the Location (.*) dropdown")]
        public void WhenClickOnTheLocationDropdown(int p0)
        {
            driver.FindElement(By.Id("downArrowIcon_child_12")).Click();
        }

        [When(@"Enable the (.*) and (.*) checkboxes")]
        public void WhenEnableTheAndCheckboxes(int p0, int p1)
        {
            driver.FindElement(By.Id("childGroup_64533")).Click();

            driver.FindElement(By.Id("childGroup_64585")).Click();
        }

        [When(@"Click on the chandu checkbox")]
        public void WhenClickOnTheChanduCheckbox()
        {
            driver.FindElement(By.Id("childGroup_65480")).Click();
        }

        [When(@"Click on the Select all checkbox")]
        public void WhenClickOnTheSelectAllCheckbox()
        {
            driver.FindElement(By.Id("allSelected")).Click();
        }

        [Then(@"Again click on the select group dropdown")]
        public void ThenAgainClickOnTheSelectGroupDropdown()
        {
            driver.FindElement(By.Id("downArrowIcon_header")).Click();
        }

    }
}
