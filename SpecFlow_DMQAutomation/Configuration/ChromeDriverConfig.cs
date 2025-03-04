using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace SpecFlow_DMQAutomation.Configuration
{
    public class ChromeDriverConfig
    {
        private IWebDriver _driver;
        private static readonly string DriverPath = Path.Combine(Directory.GetCurrentDirectory(), "/home/karbax/Documents/GIT/DEMQAAutomation/SpecFlow_DMQAutomation/Drivers/chromedriver");
        public static readonly string BaseUrl = "https://demoqa.com/";


        public IWebDriver GetDriver()
        {
            if (_driver == null)
            {
                ChromeOptions options = new ChromeOptions();
                options.AddArgument("start-maximized");
                _driver = new ChromeDriver(DriverPath, options);
                _driver.Navigate().GoToUrl(BaseUrl);
                _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
                _driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(60);
                _driver.Title.Equals("DEMOQA");
            }
            return _driver;
        }

        public void QuitDriver()
        {
            if (_driver != null)
            {
                _driver.Quit();
            }
        }
    }
}

