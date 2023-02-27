using TestFrameworkUtil.CoreLibrary;
using TestFrameworkUtil.CoreLibrarys;

namespace UITests.Tests
{
    [TestClass]
    public class BaseTest : BaseUIPage
    {
        [TestInitialize]
        public void BeforeAllTest()
        {
            Driver driver = new Driver();
            driver.InitBrowser();
            LaunchApplication();
        }

        [TestCleanup]
        public void AfterAllTest()
        {

        }
    }
}