using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using TechTalk.SpecFlow;

namespace Demo.StepDefinitions
{
    [Binding]
    public class EMptyFields     : Bla
    {
        
        [Given(@"I leave the fields empty")]
        public void GivenILeaveTheFieldsEmpty()
        {

            driver.FindElement(By.Name(username)).Clear();
            driver.FindElement(By.Name(password)).Clear();

        }
        
        [When(@"I click the login button")]
        public void WhenIClickTheLoginButton()
        {
            driver.FindElement(By.Id(login)).Click();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(driver => driver.FindElement(By.Id("myError")));
        }
        
        [Then(@"then i should nnot be allowed to login")]
        public void ThenThenIShouldNnotBeAllowedToLogin()
        {
            try
            {
                Assert.IsTrue(driver.FindElement(By.Id("myError")).Displayed);
            }
            catch(Exception fl)
            {
                Console.WriteLine(fl.Message);
                Console.ReadLine();             
            }
            
            
        }
    }
}
