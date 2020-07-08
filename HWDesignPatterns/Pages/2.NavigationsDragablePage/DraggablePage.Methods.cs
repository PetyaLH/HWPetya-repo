using HWDesignPatterns.Utilities;
using OpenQA.Selenium;


namespace HWDesignPatterns.Pages._2.NavigationsDragabblePage
{
    public partial class DraggablePage : BasePage
    {
        public DraggablePage(IWebDriver driver) : base(driver)
        {
        }            

        public void GoToAxisRestrictedTab()
        {
            AxisRestrictedTab.Click();
        }
        public void GoToContainerTab()
        {
            ContainerTab.Click();
        }
    }
}
