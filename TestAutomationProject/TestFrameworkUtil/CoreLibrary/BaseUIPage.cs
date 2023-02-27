using OpenQA.Selenium;
using TestFrameworkUtil.CoreLibraryInterfaces;
using TestFrameworkUtil.Enums;
using TestFrameworkUtil.CoreLibrary.Extensions;
using TestFrameworkUtil;

namespace TestFrameworkUtil.CoreLibrary
{
    public class BaseUIPage 
    {
        public virtual BrowserType BrowserType { get; set; }

        public virtual IBaseUIPage CurrentPage { get; set; }

        public static IWebDriver WebDriver { get; set; }



        public virtual void LaunchApplication()
        {
            WebDriver.Manage().Cookies.DeleteAllCookies();
            WebDriver.Navigate().GoToUrl(Constants.APP_URL);
            WebDriver.Manage().Window.Maximize();
            Console.WriteLine("Navigated to URL :" + Constants.APP_URL.ToString());
            //Reporter.LogPass("Navigated to URL :" + UIConfigSettings.APP_URL.ToString());
        }

        public virtual void NavigateSite(string url)
        {
           
            WebDriver.Navigate().GoToUrl(url);
            Console.WriteLine("Navigated to URL :" + url);
            //Reporter.LogPass("Navigated to URL :" + url);
        }

        public virtual void RefeshBrowser()
        {
            WebDriver.Navigate().Refresh();
            DriverExtensions.WaitUntilDocumentIsReady(WebDriver);
        }

        public void OpenURLinNewTab(string url)
        {
            ((IJavaScriptExecutor)WebDriver).ExecuteScript("window.open();");
            WebDriver.SwitchTo().Window(WebDriver.WindowHandles[WebDriver.WindowHandles.Count - 1]);
            WebDriver.Navigate().GoToUrl(url);
        }

        protected TPage GetInstance<TPage>() where TPage : BaseUIPage, new()
        {
            return (TPage)Activator.CreateInstance(typeof(TPage));
        }

        public TPage As<TPage>() where TPage : BaseUIPage
        {
            return (TPage)this;
        }
    }
}
