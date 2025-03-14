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
    private readonly FormsPanelComponent formsPanelComponent;
    private readonly PracticeForm practiceForm;
    private readonly BasePage basePage;
    private readonly FillFormsFields fillFormsDataFields;


    public PracticeFormsSteps(ScenarioContext scenarioContext)
    {
        if (scenarioContext.TryGetValue("WebDriver", out var driverObj) && driverObj is IWebDriver driver)
        {
            formsPanelComponent = new FormsPanelComponent(driver);
            practiceForm = new PracticeForm(driver);
            basePage = new BasePage(driver);
            fillFormsDataFields = new FillFormsFields(driver);
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

        foreach (var row in table.Rows)
        {
            fieldDada[row["Field"]] = row["Value"];
        }

        basePage.FormsOptionLoad();
        basePage.ClickFormsCardOption();
        practiceForm.PracticeFormOptionLoad();
        practiceForm.ClickOnPracticeForm();
        practiceForm.ClickOnMaleRadionButtonOption();
        practiceForm.ClickOnSportsCheckboxOption();
        fillFormsDataFields.FillFormForAllTipesOfElements(fieldDada);
    }

    [Then(@"The system should display a modal with a confirmation message")]
    public void TheSystemDiplayedAMessage()
    {
        string expectMessage = practiceForm.ConfirmMessagemOnTable();
        ClassicAssert.AreEqual(expectMessage, "Thanks for submitting the form");
        practiceForm.ClickOnCloseModalButton();
    }
}