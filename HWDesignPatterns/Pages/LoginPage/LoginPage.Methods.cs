using AutoFixture;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace HWDesignPatterns.Pages.LoginPage
{
    public partial class LoginPage : BasePage
    {
        public LoginPage(IWebDriver driver) : base(driver)
        {
        }
        public void SignInBtb() => Driver.FindElement(By.PartialLinkText(@"Sign in")).Click();

        public void EnterEmail()
        {
            var fixture = new Fixture();
            var mail = fixture.Create<string>() + "@gmail.com";
            Driver.FindElement(By.Id("email_create")).SendKeys(mail);
        }

        public void SubmitCreate() => Driver.FindElement(By.Id(@"SubmitCreate")).Click();
    }
}
