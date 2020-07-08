using OpenQA.Selenium;


namespace HWDesignPatterns.Pages._3.NavigationsResizablePage
{
    public partial class ResizablePage : BasePage
    {

        public IWebElement ResizableBoxWithRestrictions => Driver.FindElement(By.Id("resizableBoxWithRestriction"));
        public IWebElement ConstraintArea => Driver.FindElement(By.ClassName("constraint-area"));
        public IWebElement Handle => Driver.FindElement(By.CssSelector("#resizableBoxWithRestriction > span"));

        public IWebElement Handle2 => Driver.FindElement(By.CssSelector("#resizable > span"));
        public IWebElement ResizableBox => Driver.FindElement(By.Id("resizable"));

    }
}
