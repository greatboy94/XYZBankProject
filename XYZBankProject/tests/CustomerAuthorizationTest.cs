using NUnit.Framework;
using XYZBankProject.config;
using XYZBankProject.pageObjects;

namespace XYZBankProject.tests
{
    public class CustomerAuthorizationTest : BaseDriverSetUp
    {
        [Test]
        public void CheckCustomer()
        {
             HomePage homePage = new HomePage();
             homePage.LoginAsCustomer().Auth();
             CustomerAccount account = new CustomerAccount();
             Assert.AreEqual(BaseConfig.expectedTitle, account.GetTitle());
             account.Deposit("100");
             Assert.AreEqual(BaseConfig.expectedSuccess, account.CheckSuccess());
             account.Logout();
        }
    }
}
