using System;
using System.Collections.Generic;
using System.Diagnostics;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace TestFrameworkUtil.CoreLibrary.Extensions
{
    public static class DriverExtensions
    {
        public static void WaitUntilDocumentIsReady(IWebDriver driver)
        {
            var javaScriptExecutor = driver as IJavaScriptExecutor;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(180));

            // Check if document is ready
            Func<IWebDriver, bool> readyCondition = (webDriver => (bool)javaScriptExecutor.ExecuteScript("return (document.readyState == 'complete' && jQuery.active == 0)"));
            wait.Until(readyCondition);
        }
    }

       

}
