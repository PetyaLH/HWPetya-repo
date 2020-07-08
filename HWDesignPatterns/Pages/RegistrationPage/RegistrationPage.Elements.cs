using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace HWDesignPatterns.Pages.RegistrationPage
{
    public partial class RegistrationPage : BasePage
    {
        public IWebElement EnterFirstName => Driver.FindElement(By.Id("customer_firstname"));

        public IWebElement EnterLastName => Driver.FindElement(By.Id("customer_lastname"));

        public IWebElement  EnterPassword => Driver.FindElement(By.Id("passwd"));

        public IWebElement  EnterAddress1 => Driver.FindElement(By.Id("address1"));

        public IWebElement  EnterCity => Driver.FindElement(By.Id("city"));

        public IWebElement State => Driver.FindElement(By.Id("id_state"));

        public IWebElement EnterPostCode => Driver.FindElement(By.Id("postcode"));

        public IWebElement EnterPhoneNumber => Driver.FindElement(By.Id("phone_mobile"));

        public IWebElement  SubmitApplication => Driver.FindElement(By.Id("submitAccount"));

    }
}
