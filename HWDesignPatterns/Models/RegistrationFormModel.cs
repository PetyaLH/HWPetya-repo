using System;
using System.Collections.Generic;
using System.Text;

namespace HWDesignPatterns.Models
{
   public class RegistrationFormModel
    {
        public string EnterFirstName { get; set; }

        public string EnterLastName { get; set; }

        public string EnterPassword { get; set; }

        public string EnterAddress1 { get; set; }

        public string EnterCity { get; set; }

        public string ChooseState { get; set; }
        public string EnterPostCode { get; set; }

        public string EnterPhoneNumber { get; set; }

        public string SubmitApplication { get; set; }
    }
}
