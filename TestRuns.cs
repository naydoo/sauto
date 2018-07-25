using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Demo.StepDefinitions;
using System.Threading;

namespace Demo
{
    [TestClass]
    public class TestRuns
    {
        LoginDemoSteps login = new LoginDemoSteps();
        
        [TestMethod]
        public void TestMethod1()
        {

            login.GivenIAmOnBingoLinerLIVESite();
            login.GivenIHaveImputedValidLoginDetails();
            login.WhenIPressTheLoginButton();        
            login.ThenThenIShouldBeDirectedToTheGamesPage();
            login.WhenIClickTheLogoutButton();
            login.ThenIShouldBeLoggedOutSuccessfully();
            
        }
        public void Depositing()
        {
            
        }
    }
}
