using OpenQA.Selenium;


namespace SpecFlow_DMQAutomation.Pages.ElementsPages
{
    public class TextBoxFormPage : ElementsPanelComponent
    {
        //The elemets of the TextBoxFormPage is being find by their Id
        private IWebElement _fullNameTextBox => Driver.FindElement(By.Id("userName"));
        private IWebElement _email => Driver.FindElement(By.Id("userEmail"));
        private IWebElement _currentAddress => Driver.FindElement(By.Id("currentAddress"));
        private IWebElement _permanentAddress => Driver.FindElement(By.Id("permanentAddress"));
        private IWebElement _submitButton => Driver.FindElement(By.Id("submit"));
        private IWebElement _outPutTextArea => Driver.FindElement(By.Id("output"));

        private readonly IWebDriver Driver;
        public TextBoxFormPage(IWebDriver driver) : base(driver)
        {
            Driver = driver;
        }


        public void FillInTextBoxForm(string fullName, string email, string currentAddress, string permanentAddress)
        {
            _fullNameTextBox.Clear();
            _fullNameTextBox.SendKeys(fullName);
            _email.Clear();
            _email.SendKeys(email);
            _currentAddress.Clear();
            _currentAddress.SendKeys(currentAddress);
            _permanentAddress.Clear();
            _permanentAddress.SendKeys(permanentAddress);          
        }

        public string GetOutPutText()
        {
            return _outPutTextArea.Text;
        }

        public void ClickSubmitButton()
        {
            _submitButton.Click();
        }
    }
}
