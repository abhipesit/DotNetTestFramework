using OpenQA.Selenium;

namespace TestFrameworkUtil.CoreLibraryInterfaces
{
    public interface IBaseUIPage
    {
        IBaseUIPage CurrentPage { get; set; }

        IWebDriver WebDriver { get; set; }
    }
}
