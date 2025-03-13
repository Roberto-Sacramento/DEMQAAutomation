using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using SpecFlow_DMQAutomation.Configuration;
using OpenQA.Selenium.Interactions;

namespace SpecFlow_DMQAutomation.Pages.FormsPages;

    public class PracticeForm : FormsPanelComponent
    {
        private IWebElement _submitButton => Driver.WaitToBeVisible(By.Id("submit"));
        private IWebElement _genderRadioButton => Driver.WaitToBeVisible(By.XPath("//div[label='Male']"));
        private IWebElement _hobbiesCheckboxOption => Driver.WaitToBeVisible(By.XPath("//div[label='Sports']"));
        //private IWebElement _modalConfirmation => Driver.WaitToBeVisible(By.XPath("//div[contains(text(),'Thanks for submitting the form')]"));
        private IWebElement __closeModalButton => Driver.WaitToBeVisible(By.Id("closeLargeModal"));
        private IWebElement _modalContent => Driver.WaitToBeVisible(By.XPath("//div[@class='modal-content']"));
        private IWebElement _modalTitleMSg => Driver.WaitToBeVisible(By.XPath("//div[@class='modal-header']//div"));


        

        //| react-select-3-input| NCR  
        //| react-select-4-input| Dlhi   
        private readonly IWebDriver Driver;

        public PracticeForm(IWebDriver driver) : base(driver)
        {
            Driver = driver;
        }
        

        public string SubmitButtonLoad()
        {
            return _submitButton.Text;
        }
        public void ClickONSubmitButtont()
        {    
            Actions actions = new Actions(Driver);
            actions.MoveToElement(_submitButton).Click().Perform();
        }

        public void ClickOnMaleRadionButtonOption()
        {
            _genderRadioButton.Click();
        }

        public void ClickOnSportsCheckboxOption()
        {
            _hobbiesCheckboxOption.Click();
        }

        public string ModalConfirmation()
        {
            Driver.SwitchTo().Frame(_modalContent);
            return _modalTitleMSg.Text;
        }

        public void ClickOnCloseModalButton()
        {
            __closeModalButton.Click();
        }
    }
