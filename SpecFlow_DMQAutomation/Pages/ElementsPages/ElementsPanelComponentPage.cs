using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlow_DMQAutomation.Pages.ElementsPages
{
    public class ElementsPanelComponentPage : BasePage
    {
        private IWebElement _elementMenuCardOption => Driver.FindElement(By.XPath("//div[contains(h5, 'Elements')]"));
        private IWebElement _elementsPanelOptions => Driver.FindElement(By.XPath("//*[contains(span, 'Elements')]//div/span"));
        private IWebElement _textBoxFormOption => Driver.FindElement(By.XPath("//li[contains(span, 'Text Box')]/span"));

        private readonly IWebDriver Driver;

        public ElementsPanelComponentPage(IWebDriver driver) : base(driver)
        {
            Driver = driver;
        }

        public string ElementMenuCardOptionLoad()
        {
            return _elementMenuCardOption.Text;
        }

        public void ClickElementMenuOption()
        {
            _elementMenuCardOption.Click();
        }

        public string ElementsPanelOptionsLoad()
        {
            return _elementsPanelOptions.Text;
        }

        public string TextBoxFormOptionLoad()
        {
            return _textBoxFormOption.Text;
        }
        public void ClickTextBoxFormOption()
        {
            _textBoxFormOption.Click();
        }
    }
}
