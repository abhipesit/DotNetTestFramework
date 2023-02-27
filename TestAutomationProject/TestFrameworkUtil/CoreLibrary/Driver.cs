using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using TestFrameworkUtil.CoreLibrary;
using TestFrameworkUtil.Enums;
using TestFrameworkUtil.Helpers;

namespace TestFrameworkUtil.CoreLibrarys
{
    public class Driver : BaseUIPage
    {
        public const string _Complete = "complete";
        public const string _ReturnDocReadyState = "return document.readyState";

        public Driver()
        {
            BrowserType = BrowserType.InternetExplorer;
        }
        public void InitBrowser(string privatebrowsing = "")
        {
            switch (BrowserType)
            {
                case BrowserType.InternetExplorer:
                    WebDriver = new InternetExplorerDriver();
                    break;
                case BrowserType.FireFox:
                    WebDriver = new FirefoxDriver();
                    break;
                case BrowserType.Chrome:
                    var options = new ChromeOptions();
                    options.AddUserProfilePreference("download.default_directory", CommonHelpers.GetPath() + "temp");
                    if (privatebrowsing.ToUpper().Contains("Y"))
                    {
                        options.AddArgument(@"--incognito");
                    }
                    WebDriver = new ChromeDriver(options);
                    break;
                case BrowserType.Edge:
                    WebDriver = new EdgeDriver();
                    break;
            }
        }
    }
}
