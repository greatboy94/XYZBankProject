using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace XYZBankProject.config
{
    public class BaseDriverSetUp
    {
        protected IWebDriver driver;

        [SetUp]
        public void SetUp()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().PageLoad=(TimeSpan.FromSeconds(10));
            driver.Manage().Timeouts().ImplicitWait = (TimeSpan.FromSeconds(10));
            BasePageSetUp.SetDriver(driver);
        }

        [TearDown]
        public void TearDown()
        {
            driver.Close();
            driver.Quit();
        }
        
    }    
}

