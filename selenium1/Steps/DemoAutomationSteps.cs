using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Diagnostics;
using TechTalk.SpecFlow;

namespace selenium1.Steps
{
    [Binding]
    public class UsingIRISSuiteSteps
    {
        private POM _pom;
        private IWebDriver _driver;
        [Given(@"I'm on the login page")]
        public void GivenIMOnTheLoginPage()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();
            _pom = POM.NavigateTo(_driver);
            _pom.LoginPage();
        }
        
        [Given(@"I have entered my username (.*)")]
        public void GivenIHaveEnteredMyUsernameHussain(string u_name)
        {
            _pom.EnterText(By.XPath(_pom.UserName), u_name);
        }
        
        [Given(@"I have entered my password (.*)")]
        public void GivenIHaveEnteredMyPassword(string pass)
        {
            _pom.EnterText(By.XPath(_pom.Password), pass);
        }
        
        [When(@"I have click on submit button")]
        public void WhenIHaveClickOnSubmitButton()
        {
            _pom.ClickElement(By.XPath(_pom.Submit));
        }
        [AfterScenario]
        public void killChrome()
        {
            Process[] chromeDriverProcesses = Process.GetProcessesByName("chromedriver");
            foreach (var chromeDriverProcess in chromeDriverProcesses)
            {
                chromeDriverProcess.Kill();
            }
        }
    }
}
