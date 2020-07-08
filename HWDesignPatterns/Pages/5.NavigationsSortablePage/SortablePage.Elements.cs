using OpenQA.Selenium;


namespace HWDesignPatterns.Pages._3.NavigationsResizablePage
{
    public partial class SortablePage : BasePage
    {

        public IWebElement FirstElement => Driver.FindElement(By.CssSelector("#demo-tabpane-list > div > div:nth-child(1)"));

        public IWebElement SecondElement => Driver.FindElement(By.CssSelector("#demo-tabpane-list > div > div:nth-child(2)"));

        public IWebElement GridTab => Driver.FindElement(By.Id("demo-tab-grid"));

        public IWebElement ElementOne => Driver.FindElement(By.CssSelector("#demo-tabpane-grid > div > div > div:nth-child(1)"));

        public IWebElement ElementFive => Driver.FindElement(By.CssSelector("#demo-tabpane-grid > div > div > div:nth-child(5)"));
    }
}
