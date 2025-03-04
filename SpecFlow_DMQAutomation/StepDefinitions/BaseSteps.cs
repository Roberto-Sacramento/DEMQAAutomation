using OpenQA.Selenium;
using SpecFlow_DMQAutomation.Pages;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Infrastructure;
using TechTalk.SpecFlow.UnitTestProvider;

namespace SpecFlow_DMQAutomation.StepDefinitions
{
    [Binding]
    public class BaseSteps
    {
        public readonly BasePage _basePage;

        /*
         *ScenarioContext is a SpecFlow class that provides access to the context of the current scenario, including shared data.
         */
        public BaseSteps(ScenarioContext scenarioContext)
        {
            /*
             TryGetValue is a method that tries to get the value associated with the specified key from the ScenarioContext.
             If the key is found, the value is stored in the driverObj variable and the method returns true.
             If the key is not found, the method returns false.
             2.	ScenarioContext and WebDriver:
             • The code attempts to retrieve an object associated with the key "WebDriver" from the scenarioContext.
             •	TryGetValue is used to safely attempt to get the value without throwing an exception if the key does not exist. It returns true if the key is found and assigns the value to driverObj.
             */
            if (scenarioContext.TryGetValue("WebDriver", out var driverObj) && driverObj is IWebDriver driver)
            {
                _basePage = new BasePage(driver);
            }
            else
            {
                throw new ArgumentNullException(nameof(driver), "WebDriver is not available in the scenario context.");
            }
        }


        [Given(@"I navigate to the main page")]
        public void GivenINavigateToTheMainPage()
        {
            _basePage.ElementsOptionLoad();
            _basePage.FormsOptionLoad();
            _basePage.AlertsOptionLoad();
            _basePage.WidgetsOptionLoad();
            _basePage.InteractionsOptionLoad();
        }

    }
}
