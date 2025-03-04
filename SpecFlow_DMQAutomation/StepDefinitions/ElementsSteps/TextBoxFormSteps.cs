using NUnit.Framework;
using NUnit.Framework.Legacy;
using OpenQA.Selenium;
using SpecFlow_DMQAutomation.Pages.ElementsPages;
using TechTalk.SpecFlow;

namespace SpecFlow_DMQAutomation.StepDefinitions.ElementsSteps
{
    [Binding]
    public class TextBoxFormSteps
    {
        private readonly TextBoxFormPage _textBoxFormPage;

        public TextBoxFormSteps(ScenarioContext scenarioContext)
        {
            if (scenarioContext.TryGetValue("WebDriver", out var driverObj) && driverObj is IWebDriver driver)
            {
                _textBoxFormPage = new TextBoxFormPage(driver);
            }
            else
            {
                throw new ArgumentNullException(nameof(driver), "WebDriver is not available in the scenario context.");
            }
        }

        [When(@"I fill in the Text Box form with (.*), (.*), (.*), (.*)")]
        public void WhenIFillInTheTextBoxForm(string fullName, string email, string currentAnddress, string permanentAddress)
        {
            _textBoxFormPage.FillInTextBoxForm(fullName, email, currentAnddress, permanentAddress);
            _textBoxFormPage.ClickSubmitButton();
        }

        [Then(@"I should see the Text area filled")]
        public void ThenIShouldSeeTheTextAreaFilled()
        {           
           Assert.That(_textBoxFormPage.GetOutPutText(), Is.Not.Null.Or.Empty);    
        }



    }
}
