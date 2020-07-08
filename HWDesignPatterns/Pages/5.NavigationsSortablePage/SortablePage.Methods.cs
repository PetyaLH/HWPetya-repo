using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace HWDesignPatterns.Pages._3.NavigationsResizablePage
{
    public partial class SortablePage : BasePage
    {
        public SortablePage(IWebDriver driver) : base(driver)
        {
        }

        public void NavigateToGrid()
        {
            GridTab.Click();
        }



    }
}
