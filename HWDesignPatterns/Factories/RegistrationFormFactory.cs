using Fare;
using HWDesignPatterns.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HWDesignPatterns.Factories
{
    public static class RegistrationFormFactory
    {
        public static RegistrationFormModel CreateUser()
        {
            return new RegistrationFormModel
            {

            EnterFirstName = "Sarah",
            EnterLastName = "Paulson",
            EnterPassword = "psw3000",
            EnterAddress1 = "Five Star Hotel",
            EnterCity = "Angel City",
            ChooseState = "Alabama",            
            EnterPostCode = "90000",
            EnterPhoneNumber = "99996666"

        };

        }


    }
}
