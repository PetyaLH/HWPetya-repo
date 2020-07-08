using OpenQA.Selenium;


namespace HWDesignPatterns.Pages._2.NavigationsDragabblePage
{
    public partial class DraggablePage : BasePage
    {
        public IWebElement DraggableBox => Driver.FindElement(By.Id("dragBox"));

        public IWebElement ContainedBox => Driver.FindElement(By.CssSelector("#containmentWrapper > div"));

        public IWebElement ContainerTab => Driver.FindElement(By.Id("draggableExample-tab-containerRestriction"));

        public IWebElement AxisRestrictedTab => Wait.Until(d => d.FindElement(By.Id("draggableExample-tab-axisRestriction")));

        public IWebElement RestrictedX => Driver.FindElement(By.Id("restrictedX"));

        public IWebElement RestrictedY => Driver.FindElement(By.Id("restrictedY"));

              
    }
}
