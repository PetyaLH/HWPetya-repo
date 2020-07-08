using OpenQA.Selenium;


namespace HWDesignPatterns.Pages._3.NavigationsResizablePage
{
    public partial class SelectablePage : BasePage
    {


        public IWebElement FirstElement => Driver.FindElement(By.CssSelector("#verticalListContainer > li:nth-child(1)"));
        public IWebElement SelectableGridTab => Driver.FindElement(By.Id("demo-tab-grid"));
        public IWebElement BoxFive => Driver.FindElement(By.XPath("//*[@id='row2']/li[2]"));

    }
}
