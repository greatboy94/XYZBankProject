using NUnit.Framework;
using XYZBankProject.config;
using XYZBankProject.pageObjects;

namespace XYZBankProject.tests
{
    public class ManagerAuthorizationTest : BaseDriverSetUp
    {
        [Test]
        public void CheckManager()
        {
            HomePage homePage = new HomePage();
            homePage.LoginAsManager().AddCustomer(BaseConfig.firstName, BaseConfig.lastName, BaseConfig.postalCode);
            var alert2=driver.SwitchTo().Alert();
            alert2.Accept();
            Thread.Sleep(3000);
            
        }
    }
}

