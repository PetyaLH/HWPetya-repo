using OpenQA.Selenium;



namespace HWDesignPatterns.Utilities
{
    public static class DriverExtensions
    {
        public static void ScrollTo(this IWebDriver driver, IWebElement element) //extension method
        {
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", element);
        }
    }
}

