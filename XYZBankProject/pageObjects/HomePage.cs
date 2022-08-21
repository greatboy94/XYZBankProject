using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using XYZBankProject.config;

namespace XYZBankProject.pageObjects
{
    public class HomePage : BasePageSetUp
    {
        [FindsBy(How = How.XPath, Using = "//button[@ng-click='customer()']")]
        public IWebElement customerLoginButton;
        
        [FindsBy(How = How.XPath, Using = "//button[@ng-click='manager()']")]
        public IWebElement managerLoginButton;

        public HomePage()
        {
            driver.Navigate().GoToUrl(BaseConfig.baseURL);
            PageFactory.InitElements(driver, this);
        }

        public CustomerAuthorization LoginAsCustomer()
        {
            customerLoginButton.Click();
            return new CustomerAuthorization();
        }
        
    }    
}