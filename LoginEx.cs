using System;
namespace C969Scheduling
{
    class LoginEx : ApplicationException
    {
        public LoginEx() : base("Please correct input.")
        {

        }
        public LoginEx(string exemptionMessage) : base(exemptionMessage)
        {

        }
        public LoginEx(string exemptionMessage, ApplicationException inner) : base(exemptionMessage, inner)
        {

        }
    }
}
