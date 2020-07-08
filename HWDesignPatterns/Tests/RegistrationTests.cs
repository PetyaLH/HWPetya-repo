using HWDesignPatterns.Factories;
using HWDesignPatterns.Models;
using HWDesignPatterns.Pages.RegistrationPage;
using NUnit.Framework;


namespace HWDesignPatterns.Tests
{
    [TestFixture]
    public class PracticeFormTests : BaseTest
    {
        private LoginForm _emailReg;
        private RegistrationPage _registrationPage;
        private RegistrationFormModel _user;

        [SetUp]
        public void Setup()
        {
            Initialize();
            Maximize();
            //NavigateTo();
            Driver.Navigate().GoToUrl("http://automationpractice.com/index.php");


            _emailReg = new LoginForm(Driver);
            _emailReg.FillLoginForm();

            _registrationPage = new RegistrationPage(Driver);
            _user = RegistrationFormFactory.CreateUser();
        }
        
        [Test]
        public void FillFormWithValidData()
        {

            _registrationPage.FillForm(_user);

            _registrationPage.AssertPageTitle();

        }
        [Test]
        public void FillFormWithInvalidData_woFirstName()
        {
            //Arange
            _user.EnterFirstName = string.Empty;
            //Act
            _registrationPage.FillForm(_user);
            //Assert
            _registrationPage.Assert_FirstNameIsRequired();
        }

        [Test]
        public void FillFormWithInvalidData_woLastName()
        {
            //Arange
            _user.EnterLastName = string.Empty;
            //Act
            _registrationPage.FillForm(_user);
            //Assert
            _registrationPage.Assert_LastNameIsRequired();
        }
        [Test]
        public void FillFormWithInvalidData_woPassword()
        {
            //Arange
            _user.EnterPassword = string.Empty;
            //Act
            _registrationPage.FillForm(_user);
            //Assert
            _registrationPage.Assert_PasswordIsRequired();
        }

        [Test]
        public void FillFormWithInvalidData_woAddress1()
        {
            //Arange
            _user.EnterAddress1 = string.Empty;
            //Act
            _registrationPage.FillForm(_user);
            //Assert
            _registrationPage.Assert_Address1IsRequired();
        }

        [Test]
        public void FillFormWithInvalidData_woCity()
        {
            //Arange
            _user.EnterCity = string.Empty;
            //Act
            _registrationPage.FillForm(_user);
            //Assert
            _registrationPage.Assert_CityIsRequired();
        }

        [Test]
        public void FillFormWithInvalidData_woState()
        {
            //Arange
            _user.ChooseState = "-";
            //Act
            _registrationPage.FillForm(_user);
            //Assert
            _registrationPage.Assert_StateIsRequired();
        }
        [Test]
        public void FillFormWithInvalidData_woPostCode()
        {
            //Arange
            _user.EnterPostCode = string.Empty;
            //Act
            _registrationPage.FillForm(_user);
            //Assert
            _registrationPage.Assert_PostCodeIsRequired();
        }

        [Test]
        public void FillFormWithInvalidData_woPhoneNumber()
        {
            //Arange
            _user.EnterPhoneNumber = string.Empty;
            //Act
            _registrationPage.FillForm(_user);
            //Assert
            _registrationPage.Assert_PhoneIsRequired();
        }


        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}
