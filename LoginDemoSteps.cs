using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Security.Policy;
using System.Threading;
using TechTalk.SpecFlow;

namespace Demo.StepDefinitions
{
    
    [Binding]
    public class LoginDemoSteps     : bla
    {
        public IWebDriver driver = new ChromeDriver();
        
        
        [Given(@"I am on bingo liner LIVE site")]
        public void GivenIAmOnBingoLinerLIVESite()
        {
            
            driver.Navigate().GoToUrl(site);
            
        }
        
        [Given(@"I have imputed valid login details")]
        public void GivenIHaveImputedValidLoginDetails()
        {
            driver.FindElement(By.Name(username)).SendKeys("poodles2");
            driver.FindElement(By.Name(password)).SendKeys("qqq111");
        }
        
        [When(@"I press the login button")]
        public void WhenIPressTheLoginButton()
        {
            driver.FindElement(By.Id(login)).Click();
        }

        [Then(@"then i should be directed to the games page")]
        public void ThenThenIShouldBeDirectedToTheGamesPage()
        {
        }
            
                    [When(@"i click the logout button")]
        public void WhenIClickTheLogoutButton()
        {
            Thread.Sleep(5000);
            driver.FindElement(By.Id(menu)).Click();
            driver.FindElement(By.Id(logout)).Click();
        }

        [Then(@"i should be logged out successfully")]
        public void ThenIShouldBeLoggedOutSuccessfully()
        {
            
            if (driver.FindElement(By.Id(login)).Displayed == true)
            {
                Console.WriteLine("loggedlout successfully");
                Console.ReadLine();
            }
            if (driver.FindElement(By.Id(login)).Displayed == false)
            {
                Thread.Sleep(7000);
            }
            
           
        }


     


    }
}
              