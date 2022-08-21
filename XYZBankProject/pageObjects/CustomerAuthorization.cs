using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using XYZBankProject.config;

namespace XYZBankProject.pageObjects
{
    public class CustomerAuthorization : BasePageSetUp
    {
        [FindsBy(How = How.XPath, Using = "//select[@id='userSelect']")]
        public IWebElement selectYourName;

        [FindsBy(How = How.XPath, Using = "//option[@value='1']")]
        public IWebElement selectFirstOption;

        [FindsBy(How = How.XPath, Using = "//button[@type='submit']")]
        public IWebElement loginButton;

        public CustomerAuthorization()
        {
            PageFactory.InitElements(driver, this);
        }

        public CustomerAccount Auth()
        {
            selectYourName.Click();
            selectFirstOption.Click();
            loginButton.Click();
            return new CustomerAccount();
        }
    }
}

