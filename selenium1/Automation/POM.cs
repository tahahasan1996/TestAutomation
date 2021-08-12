using OpenQA.Selenium;

namespace selenium1
{
    class POM : Core
    {
        public POM (IWebDriver driver)
        {
            _driver = driver;
        }
        public static POM NavigateTo(IWebDriver driver)
        {
            return new selenium1.POM(driver);
            
        }
        public void LoginPage()
        {
            _driver.Navigate().GoToUrl("http://demo.guru99.com/test/newtours/index.php");
        }       
        public string UserName= "//input[@name='userName']";                   
        public string Password= "//input[@name='password']";
        public string Submit = "//input[@name='submit']";
               
        
    }        
}
