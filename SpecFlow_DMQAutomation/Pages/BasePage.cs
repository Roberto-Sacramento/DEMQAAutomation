using OpenQA.Selenium;

namespace SpecFlow_DMQAutomation.Pages
{
    public class BasePage
    {
        #region
        private IWebElement _elementOption => Driver.FindElement(By.XPath("//div[contains(h5, 'Elements')]"));
        private IWebElement _formsOption => Driver.FindElement(By.XPath("//div[contains(h5, 'Forms')]"));
        private IWebElement _alerts_Frame_WindowsOption => Driver.FindElement(By.XPath("//div[contains(h5, 'Alerts, Frame & Windows')]"));
        private IWebElement _widgetOption => Driver.FindElement(By.XPath("//div[contains(h5, 'Widgets')]"));
        private IWebElement _interactionsOption => Driver.FindElement(By.XPath("//div[contains(h5, 'Interactions')]"));
        #endregion

        private readonly IWebDriver Driver;
        public BasePage(IWebDriver driver)
        {
            Driver = driver;
        }

        public void ClickElementOption()
        {
            _elementOption.Click();
        }

        public void ClickFormsOption()
        {
            _formsOption.Click();
        }

        public void ClickAlertsOption() 
        {
            _alerts_Frame_WindowsOption.Click();
        }

        public void ClickWidgetsOption()
        {
            _widgetOption.Click();
        }

        public void ClickInteractionsOption()
        {
            _interactionsOption.Click();
        }

        public string ElementsOptionLoad()
        {
            return _elementOption.Text;
        }

        public string FormsOptionLoad()
        {
            return _formsOption.Text;
        }

        public string AlertsOptionLoad()
        {
            return _alerts_Frame_WindowsOption.Text;
        }
        public string WidgetsOptionLoad()
        {
            return _widgetOption.Text;
        }

        public string InteractionsOptionLoad() 
        {
            return _interactionsOption.Text;
        }

    }
}
