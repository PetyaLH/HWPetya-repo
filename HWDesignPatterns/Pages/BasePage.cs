using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace HWDesignPatterns.Pages
{
    public class BasePage
    {
        public IWebDriver Driver { get; }
        public WebDriverWait Wait { get; }


        public BasePage(IWebDriver driver)
        {
            Driver = driver;
            Wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(15));
        }

        public IWebElement ScrollTo(IWebElement element)
        {
            ((IJavaScriptExecutor)Driver).ExecuteScript("arguments[0].scrollIntoView(true);", element);
            return element;
        }

        public void WaitToLoad()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(15));
        }

        public string ValidationErrors()
        {
            return Driver.FindElement(By.CssSelector("#center_column > div > ol > li")).Text;
        }

        private const string PageUrl = "http://demoqa.com";
        public void NavigateTo()
        {
            Driver.Navigate().GoToUrl(PageUrl);
        }

        public WebDriverWait WaitPageToLoad()
        {
            return new WebDriverWait(Driver, TimeSpan.FromSeconds(5));
        }
        public ReadOnlyCollection<IWebElement> InteractionTable
        {
            get
            {
                return Driver.FindElements(By.XPath("//*[@id='app']/div/div/div[2]/div/div"));
            }
        }
        public ReadOnlyCollection<IWebElement> InteractionList
        {
            get
            {
                return Driver.FindElements(By.XPath("//div/div[5]//ul/li"));
            }
        }
        public IWebElement ScrToSection => Driver.FindElement(By.Id("botton-text-10"));

    }

}
    

