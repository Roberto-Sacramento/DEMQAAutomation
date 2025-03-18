using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SpecFlow_DMQAutomation.Configuration;
using SpecFlow_DMQAutomation.Pages;

namespace SpecFlow_DMQAutomation.Utils
{
    public class FillFormsFields : BasePage
    {
        private readonly IWebDriver Driver;

        public FillFormsFields(IWebDriver driver) : base(driver)
        {
            Driver = driver;
        }
        public void FillTheFormFields(Dictionary<string, string> fieldData)
        {

            foreach (var field in fieldData)
            {
                Driver.WaitToBeVisible(By.Id(field.Key)).SendKeys(field.Value);
            }

        }

        /*
        Dropdowns (<select> tags) are handled using SelectElement.

        Radio buttons and checkboxes are determined by the type attribute of the <input> tag.

        Text fields, email fields, password fields, and other similar input fields are handled by checking and setting their values accordingly.

        Text areas (<textarea> tags) are handled separately.
        */
        public void FillFormForAllTipesOfElements(Dictionary<string, string> fieldData)
        {
            foreach (var field in fieldData)
            {
                IWebElement element = Driver.WaitToBeVisible(By.Id(field.Key));
                string value = field.Value;

                switch (element.TagName.ToLower())
                {
                    case "select": // Dropdown
                        SelectElement selectElement = new SelectElement(element);
                        selectElement.SelectByValue(value); // or selectElement.SelectByText(value);
                        break;
                    case "input":
                        string type = element.GetAttribute("type").ToLower();
                        element.Selected.Should();
                        switch (type)
                        {
                            case "radio": // Radio button
                                if (element.GetAttribute("value").Equals(value, StringComparison.OrdinalIgnoreCase))
                                {
                                    element.Click();
                                }
                                break;
                            case "checkbox": // Checkbox
                                bool shouldCheck = bool.Parse(value);
                                if (element.Selected != shouldCheck)
                                {
                                    element.Click();
                                }
                                break;
                            case "text": // Text field
                            case "email":
                            case "password":
                            default:
                                element.Clear();
                                element.SendKeys(value);
                       
                                break;
                        }
                        break;
                    case "textarea": // Text area
                        element.Clear();
                        element.SendKeys(value);
                        element.Submit();
                        break;
                    default:
                        throw new NotSupportedException($"Element of type {element.TagName} is not supported.");
                }
            }
        }

    }


}