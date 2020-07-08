using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace HWDesignPatterns.Pages.RegistrationPage
{
    public partial class RegistrationPage : BasePage
    {
        public void AssertPageTitle()
        {
            WaitToLoad();
            Assert.AreEqual("My account - My Store", Driver.Title);
        }

        public void Assert_FirstNameIsRequired()
        {
            WaitToLoad();
            Assert.AreEqual("firstname is required.", ValidationErrors());
        }

        public void Assert_LastNameIsRequired()
        {
            WaitToLoad();
            Assert.AreEqual("lastname is required.", ValidationErrors());
        }

        public void Assert_PasswordIsRequired()
        {
            WaitToLoad();
            Assert.AreEqual("passwd is required.", ValidationErrors());
        }

        public void Assert_Address1IsRequired()
        {
            WaitToLoad();
            Assert.AreEqual("address1 is required.", ValidationErrors());
        }

        public void Assert_CityIsRequired()
        {
            WaitToLoad();
            Assert.AreEqual("city is required.", ValidationErrors());
        }

        public void Assert_PostCodeIsRequired()
        {
            WaitToLoad();
            Assert.AreEqual("The Zip/Postal code you've entered is invalid. It must follow this format: 00000", ValidationErrors());
        }

        public void Assert_StateIsRequired()
        {
            WaitToLoad();
            Assert.AreEqual("This country requires you to choose a State.", ValidationErrors());
        }

        public void Assert_PhoneIsRequired()
        {
            WaitToLoad();
            Assert.AreEqual("You must register at least one phone number.", ValidationErrors());
        }
    }
}

