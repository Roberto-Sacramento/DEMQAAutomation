using OpenQA.Selenium;
using SpecFlow_DMQAutomation.Configuration;
using SpecFlow_DMQAutomation.Pages;

namespace SpecFlow_DMQAutomation.Utils
{
    public class FillFormsDataFields : BasePage
    {
        private readonly IWebDriver Driver;

        public FillFormsDataFields(IWebDriver driver) : base(driver)
        {
            Driver = driver;
        }
        public void FillTheFormFields(Dictionary<string, string> fieldData)
        {

            foreach(var field in fieldData)
            {
                Driver.WaitToBeVisible(By.Id(field.Key)).SendKeys(field.Value);
            }

        }
    }
}