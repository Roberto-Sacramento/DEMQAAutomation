using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SpecFlow_DMQAutomation.Configuration;
using TechTalk.SpecFlow;

namespace SpecFlow_DMQAutomation.Hooks
{
    [Binding]
    public class Hooks
    {
        private readonly ScenarioContext _scenarioContext;
        private readonly ChromeDriverConfig _chromeDriverConfig;

        public Hooks(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _chromeDriverConfig = new ChromeDriverConfig();
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            IWebDriver driver = _chromeDriverConfig.GetDriver();
            _scenarioContext["WebDriver"] = driver;
        }

        [AfterScenario]
        public void AfterScenario()
        {
            _chromeDriverConfig.QuitDriver();
        }
    }
}
