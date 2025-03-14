using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace SpecFlow_DMQAutomation.Configuration
{
 public static class WebDriverExtensions
 {
    /*
    Explanation:
    Lambda Expression:

    The WaitToBeVisible method now uses a lambda expression within the Until method to wait for the element to be visible.

    The lambda expression checks if the element is displayed and returns the element if it is; otherwise, it returns null.
     */

    public static IWebElement WaitToBeVisible(this IWebDriver Driver, By by)
    {
        var wait = new WebDriverWait(Driver, WebDriverConfig.DefaultTimeout);
        return wait.Until(drv =>
        {
            var element = drv.FindElement(by);
            return element.Displayed ? element : null;
        });
    }



  } 
}