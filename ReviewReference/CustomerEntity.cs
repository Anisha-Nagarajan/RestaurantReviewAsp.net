using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewReference
{
    public class CustomerEntity
    {

        public string UserName { get; set; }
        public string Password { get; set; }
        //public string ConfirmPassword { get; set; }
        public string Email { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Pincode { get; set; }
        public string Country { get; set; }
        public string PhoneNumber { get; set; }
        public CustomerEntity(string UserName,string Password, string Email, string Street, string City, string State, string Pincode,string Country, string PhoneNumber)
        {
            this.UserName = UserName;
            this.Password = Password;
            this.Email = Email;
            this.Street = Street;
            this.City = City;
            this.State = State;
            this.Pincode = Pincode;
            this.Country = Country;
            this.PhoneNumber = PhoneNumber;

        }

       
    }
}
