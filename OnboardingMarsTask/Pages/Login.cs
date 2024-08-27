using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnboardingMarsTask.Utilities;

namespace OnboardingMarsTask.Pages
{
    public class LoginPage: CommonDriver

    {
        private IWebDriver driver;

        public LoginPage(IWebDriver driver)

        { 
            this.driver = driver;
           
        
          }

        private readonly By signin = By.XPath("//a[normalize-space()='Sign In']");
        private readonly By emailaddress = By.XPath("//input[@placeholder='Email address']");
        private readonly By password = By.XPath("//input[@placeholder='Password']");
        private readonly By login = By.XPath("//button[contains(text(),'Login')]");
        private readonly By welcometext = By.XPath("//div/div[1]/div[2]/div/span");

        public void loginActions() {
            driver.Navigate().GoToUrl("https://localhost500");
        
        driver.FindElement (signin).Click ();
                
                }
        
        }
       
    }
    
}