using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SpecFlow_DMQAutomation.Configuration;

namespace SpecFlow_DMQAutomation.Pages.FormsPages
{
    public class FormsPanelComponent : BasePage
    {
        private readonly IWebDriver Driver;
        private IWebElement _forms => Driver.WaitToBeVisible(By.XPath("//div[contains(span,'Forms')]"));
        private IWebElement _practiceForm => Driver.WaitToBeVisible(By.XPath("//*[text()='Practice Form']")); // finding the selector by Text selector

        public FormsPanelComponent(IWebDriver driver) : base(driver)
        {
            Driver = driver;
        }

        public string FormPainelOptionLoad()
        {
            return _forms.Text;
        }

        public string PracticeFormOptionLoad()
        {
            return _practiceForm.Text;
        }

        public void ClickOnFormsOption()
        {
            _forms.Click();
        }

        public void ClickOnPracticeForm()
        {
            _practiceForm.Click();
        }
    }
}