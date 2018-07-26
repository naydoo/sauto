using System;
using TechTalk.SpecFlow;
using Demo.StepDefinitions;
using OpenQA.Selenium;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;

namespace Demo.StepDefinitions
{
    [Binding]
    public class LoginUnsuccessful   : Bla
    { 
        
        [Given(@"I have imputed invalid login details")]
        public void GivenIHaveImputedInvalidLoginDetails()
        {
          
            driver.FindElement(By.Name(username)).SendKeys("poodle2");
            driver.FindElement(By.Name(password)).SendKeys("qqqzzz");
        }
        
        [When(@"I click on the login button")]
        public void WhenIClickOnTheLoginButton()
        {
            driver.FindElement(By.Id(login)).Click();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(driver => driver.FindElement(By.Id("errorMessages")));
        }
        
        [Then(@"then i should not be prevented from login in")]
        public void ThenThenIShouldNotBePreventedFromLoginIn()
        {
            try
            {
                
                Assert.IsTrue(driver.FindElement(By.Id("")).Displayed);
            }
            catch(Exception ex)
            {
                Console.WriteLine("this is no where to be found" + ex);
                Console.ReadLine();
            }
        }
    }
}
