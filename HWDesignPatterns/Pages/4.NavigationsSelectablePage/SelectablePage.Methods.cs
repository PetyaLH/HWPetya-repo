using OpenQA.Selenium;


namespace HWDesignPatterns.Pages._3.NavigationsResizablePage
{
    public partial class SelectablePage : BasePage
    {
        public SelectablePage(IWebDriver driver) : base(driver)
        {
        }
        public void NavigateToSelectableGridTab()
        {
            SelectableGridTab.Click();
        }

        public void SelectFirstElement()
        {
            FirstElement.Click();
        }
        public void SelectFifthElement()
        {
            BoxFive.Click();
        }

    }
}
