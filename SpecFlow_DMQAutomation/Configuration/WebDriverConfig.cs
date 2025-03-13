using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SpecFlow_DMQAutomation.Configuration
{
    public class WebDriverConfig
    {
        //This implementation defines a default wait for all elements in the project classes
        public static readonly TimeSpan DefaultTimeout = TimeSpan.FromSeconds(60);
    }
}