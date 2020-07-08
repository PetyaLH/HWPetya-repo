using HWDesignPatterns.Pages.LoginPage;
using OpenQA.Selenium;


namespace HWDesignPatterns.Tests
{
    public class LoginForm : LoginPage
    {
        public LoginForm(IWebDriver driver) : base(driver)
        {
        }
        public void FillLoginForm() 
        {
            WaitToLoad();
            SignInBtb();
            EnterEmail();
            SubmitCreate();
        }
    }
}
