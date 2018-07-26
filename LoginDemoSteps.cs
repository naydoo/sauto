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
    public class LoginDemoSteps : Bla
    {
        

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
            driver.FindElement(By.Id("menuBankDeposit")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.Id("renderer")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.Name("cardNumber")).SendKeys("4111111111111111");
            driver.FindElement(By.Name("firstName")).SendKeys("stan");
            driver.FindElement(By.Name("lastName")).SendKeys("opara");
            driver.FindElement(By.Name("month")).SendKeys("11");
            driver.FindElement(By.Name("year")).SendKeys("22");
            driver.FindElement(By.Name("cvc")).SendKeys("123");
            driver.FindElement(By.Id("depositNext")).Click();
            driver.FindElement(By.Id("deposit")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.Id("closeBtn")).Click();
            driver.FindElement(By.Id("menuToggleShell")).Click();
            driver.FindElement(By.Id(logout)).Click();
        }



    }





}
