using System;
using TechTalk.SpecFlow;
using SpecFlow_DMQAutomation.Pages.ElementsPages;
using OpenQA.Selenium;
using SpecFlow_DMQAutomation.Pages;

namespace SpecFlow_DMQAutomation.StepDefinitions.ElementsSteps
{
    [Binding]
    public class ElementsPageSteps 
    {
        private readonly ElementsPanelComponentPage _elementsPanelComponent;

        public ElementsPageSteps(ScenarioContext scenarioContext)
        {
            if (scenarioContext.TryGetValue("WebDriver", out var driverObj) && driverObj is IWebDriver driver)
            {
                _elementsPanelComponent = new ElementsPanelComponentPage(driver);
            }
            else
            {
                throw new ArgumentNullException(nameof(driver), "WebDriver is not available in the scenario context.");
            }
        }

        [When(@"I navigate to Elements page")]
        public void INavidageToElementsPage()
        {
            _elementsPanelComponent.ElementMenuCardOptionLoad();
            _elementsPanelComponent.ClickElementMenuOption();
            _elementsPanelComponent.ElementsPanelOptionsLoad();
            _elementsPanelComponent.TextBoxFormOptionLoad();
            _elementsPanelComponent.ClickTextBoxFormOption();
        }

       
    }
}
