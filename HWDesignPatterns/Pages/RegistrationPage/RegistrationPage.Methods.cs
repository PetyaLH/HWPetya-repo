using AutoFixture;
using Fare;
using HWDesignPatterns.Models;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;


namespace HWDesignPatterns.Pages.RegistrationPage
{
    public partial class RegistrationPage : BasePage
    {
        public RegistrationPage(IWebDriver driver) : base(driver)
        {
        }

        public void FillForm(RegistrationFormModel user)
        {
                     
                EnterFirstName.SendKeys(user.EnterFirstName);

                EnterLastName.SendKeys(user.EnterLastName);

                EnterPassword.SendKeys(user.EnterPassword);

                EnterAddress1.SendKeys(user.EnterAddress1);

                EnterCity.SendKeys(user.EnterCity);

                State.SendKeys(user.ChooseState);

                EnterPostCode.SendKeys(user.EnterPostCode);

                EnterPhoneNumber.SendKeys(user.EnterPhoneNumber);

                SubmitApplication.Click();
        }

    }
}


