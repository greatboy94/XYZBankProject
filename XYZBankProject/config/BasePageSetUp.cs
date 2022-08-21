using OpenQA.Selenium;

namespace XYZBankProject.config
{
    public class BasePageSetUp
    {
        protected static IWebDriver driver;

        public static void SetDriver(IWebDriver webDriver)
        {
            driver = webDriver;
        }
    }    
}