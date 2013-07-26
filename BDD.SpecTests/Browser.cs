using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace BDD.SpecTests
{
    public class Browser
    {
        private static IWebDriver _webDriver;

        public static IWebDriver Instance
        {
            get { return _webDriver ?? (_webDriver = new FirefoxDriver()); }
            set { _webDriver = value; }
        }

    }
}