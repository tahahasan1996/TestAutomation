using OpenQA.Selenium;
using System.Threading;

namespace selenium1
{
    public class Core
    {
        public IWebDriver _driver;


        public void EnterText(By by, string setValue)
        {
            Thread.Sleep(500);
            _driver.FindElement(by).SendKeys(setValue);
        }
        public void ClickElement(By by)
        {
            Thread.Sleep(1000);
            _driver.FindElement(by).Click();
        }
    }
}
