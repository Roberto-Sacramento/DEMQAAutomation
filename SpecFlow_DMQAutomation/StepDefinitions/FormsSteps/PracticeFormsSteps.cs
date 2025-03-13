using NUnit.Framework;
using NUnit.Framework.Legacy;
using OpenQA.Selenium;
using SpecFlow_DMQAutomation.Pages;
using SpecFlow_DMQAutomation.Pages.FormsPages;
using SpecFlow_DMQAutomation.Utils;

namespace SpecFlow_DMQAutomation.StepDefinitions.FormsSteps;

    [Binding]
    public class PracticeFormsSteps
    {
        private readonly FormsPanelComponent _formsPanelComponent;
        private readonly PracticeForm _practiceForm;
        private readonly BasePage _basePage;
        private readonly FillFormsDataFields _fillFormsDataFields;


        public PracticeFormsSteps(ScenarioContext scenarioContext)
        {
            if (scenarioContext.TryGetValue("WebDriver", out var driverObj) && driverObj is IWebDriver driver)
            {
                 _formsPanelComponent = new FormsPanelComponent(driver);
                 _practiceForm = new PracticeForm(driver);
                 _basePage = new BasePage(driver);
                 _fillFormsDataFields = new FillFormsDataFields(driver);
            }
            else
            {
                throw new ArgumentNullException(nameof(driver), "WebDriver is not available in the scenario context.");
            }
        }

        [When(@"I fill the Form fields with the following data:")]
        public void FillTheFormFieldsWithTheFollowingData(Table table)
        {
            Dictionary<string, string> fieldDada = new Dictionary<string, string>();

            foreach(var row in table.Rows)
            {
                fieldDada[row["Field"]] = row["Value"];
            }

            _basePage.FormsOptionLoad();
            _basePage.ClickFormsCardOption();
            _practiceForm.PracticeFormOptionLoad();
            _practiceForm.ClickOnPracticeForm();
            _practiceForm.ClickOnMaleRadionButtonOption(); 
            _practiceForm.ClickOnSportsCheckboxOption();       
            _fillFormsDataFields.FillTheFormFields(fieldDada);
            _practiceForm.SubmitButtonLoad();
            _practiceForm.ClickONSubmitButtont();  
            _practiceForm.ClickOnCloseModalButton();       
        }

        [Then(@"The system should display a modal with a confirmation message")]
        public void TheSystemDiplayedAMessage()
        {
            string expectMessage = _practiceForm.ModalConfirmation();
            ClassicAssert.AreEqual(expectMessage, "Thanks for submitting the form");
            
        }
    }