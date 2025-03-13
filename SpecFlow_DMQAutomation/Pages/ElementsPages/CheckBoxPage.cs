using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlow_DMQAutomation.Pages.ElementsPages
{
    class CheckBoxPage : ElementsPanelComponent
    {
        private IWebElement _checkBoxSidePanelOption => Driver.FindElement(By.XPath("//li[contains(span, 'Check Box')]/span"));
        private readonly IWebDriver Driver;
        public CheckBoxPage(IWebDriver driver) : base(driver)
        {
            Driver = driver;
        }
    }
}
