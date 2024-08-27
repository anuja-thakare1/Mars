using OnboardingMarsTask.Utilities;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace OnboardingMarsTask.StepDefinitions
{
    [Binding]
    public class LoginFeatureStepDefinition: CommonDriver
    {
        [BeforeScenario]
        public void setup( ) { 
            driver = newChromeDriver();
        
        }

        [Given(@"User is navigated to mars applictions")]
        public void GivenUserIsNavigatedToMarsApplictions()
        {
            throw new PendingStepException();
        }

        [When(@"user enter username and password click login")]
        public void WhenUserEnterUsernameAndPasswordClickLogin()
        {
            throw new PendingStepException();
        }

        [Then(@"user must be logged in to the application")]
        public void ThenUserMustBeLoggedInToTheApplication()
        {
            throw new PendingStepException();
        }
    }
}
