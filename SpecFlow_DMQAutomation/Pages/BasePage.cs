using OpenQA.Selenium;
using SpecFlow_DMQAutomation.Configuration;
namespace SpecFlow_DMQAutomation.Pages
{
    public class BasePage
    {
        #region
        private IWebElement _elementCardOption => Driver.FindElement(By.XPath("//div[contains(h5, 'Elements')]"));
        private IWebElement _formsCardOption => Driver.FindElement(By.XPath("//div[contains(h5, 'Forms')]"));
        private IWebElement _alerts_Frame_WindowsCardOption => Driver.FindElement(By.XPath("//div[contains(h5, 'Alerts, Frame & Windows')]"));
        private IWebElement _widgetsCardOption => Driver.FindElement(By.XPath("//div[contains(h5, 'Widgets')]"));
        private IWebElement _interactionsCardOption => Driver.FindElement(By.XPath("//div[contains(h5, 'Interactions')]"));
        #endregion

        private readonly IWebDriver Driver;
        public BasePage(IWebDriver driver)
        {
            Driver = driver;
        }

        public void ClickElementCardOption()
        {
            _elementCardOption.Click();
        }

        public void ClickFormsCardOption()
        {
            _formsCardOption.Click();
        }

        public void ClickAlertsCardOption() 
        {
            _alerts_Frame_WindowsCardOption.Click();
        }

        public void ClickWidgetCardsOption()
        {
            _widgetsCardOption.Click();
        }

        public void ClickInteractionsCardOption()
        {
            _interactionsCardOption.Click();
        }

        public string ElementsOptionLoad()
        {
            return _elementCardOption.Text;
        }

        public string FormsOptionLoad()
        {
            return _formsCardOption.Text;
        }

        public string AlertsOptionLoad()
        {
            return _alerts_Frame_WindowsCardOption.Text;
        }
        public string WidgetsOptionLoad()
        {
            return _widgetsCardOption.Text;
        }

        public string InteractionsOptionLoad() 
        {
            return _interactionsCardOption.Text;
        }

    }
}
