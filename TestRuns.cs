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
        EMptyFields empty = new EMptyFields();
        LoginUnsuccessful unsuccessful = new LoginUnsuccessful();

        [TestMethod]
        public void TestMethod1()
        {
            empty.GivenILeaveTheFieldsEmpty();
            empty.WhenIClickTheLoginButton();
            empty.ThenThenIShouldNnotBeAllowedToLogin();
        }
        public void TestMethod2()
        {
            unsuccessful.GivenIHaveImputedInvalidLoginDetails();
            unsuccessful.WhenIClickOnTheLoginButton();
            unsuccessful.ThenThenIShouldNotBePreventedFromLoginIn();
        }
        public void TestMethod3()
        {
            login.GivenIAmOnBingoLinerLIVESite();
            login.GivenIHaveImputedValidLoginDetails();
            login.WhenIPressTheLoginButton();
            login.ThenThenIShouldBeDirectedToTheGamesPage();
            login.WhenIClickTheLogoutButton();
        }
            


        }

    }
