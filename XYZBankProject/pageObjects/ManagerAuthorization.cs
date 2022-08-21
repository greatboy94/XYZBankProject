using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using XYZBankProject.config;

namespace XYZBankProject.pageObjects
{
    public class ManagerAuthorization : BasePageSetUp
    {

        [FindsBy(How = How.XPath, Using = "//button[@ng-class='btnClass1']")]
        public IWebElement addCustomerButton;

        [FindsBy(How = How.XPath, Using = "//input[@ng-model='fName']")]
        public IWebElement firstName;
        
        [FindsBy(How = How.XPath, Using = "//input[@ng-model='lName']")]
        public IWebElement lastName;
        
        [FindsBy(How = How.XPath, Using = "//input[@ng-model='postCd']")]
        public IWebElement postalCode;
        
        [FindsBy(How = How.XPath, Using = "//button[@type='submit']")]
        public IWebElement submitButton;

        
        public ManagerAuthorization()
        {
            PageFactory.InitElements(driver, this);
        }

        public ManagerAuthorization AddCustomer(string first, string last, string code)
        {
            addCustomerButton.Click();
            firstName.SendKeys(first);
            lastName.SendKeys(last);
            postalCode.SendKeys(code);
            submitButton.Click();
            return this;
        }
    }   
}