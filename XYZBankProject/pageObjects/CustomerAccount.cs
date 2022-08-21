using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using XYZBankProject.config;

namespace XYZBankProject.pageObjects
{
    public class CustomerAccount : BasePageSetUp
    {
        [FindsBy(How = How.XPath, Using = "//span[@class='fontBig ng-binding']")]
        public IWebElement accountTitle;

        [FindsBy(How = How.XPath, Using = "//button[@ng-class='btnClass2']")]
        public IWebElement depositButton;

        [FindsBy(How = How.XPath, Using = "//input[@type='number']")]
        public IWebElement typeSum;

        [FindsBy(How = How.XPath, Using = "//button[@type='submit']")]
        public IWebElement submitButton;

        [FindsBy(How = How.XPath, Using = "//span[@ng-show='message']")]
        public IWebElement successText;

        [FindsBy(How = How.XPath, Using = "//button[@ng-show='logout']")]
        public IWebElement logout;

        public CustomerAccount()
        {
            PageFactory.InitElements(driver, this);
        }

        public string GetTitle()
        {
            return accountTitle.Text;
        }

        public void Deposit(String sum)
        {
            depositButton.Click();
            typeSum.SendKeys(sum);
            submitButton.Click();
        }

        public string CheckSuccess()
        {
            return successText.Text;
        }

        public HomePage Logout()
        {
            logout.Click();
            return new HomePage();
        }
    }    
}