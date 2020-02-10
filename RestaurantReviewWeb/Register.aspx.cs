using System;
using System.Data;
using System.Data.SqlClient;
using RestaurantReviewBL;
using RestaurantReviewEntity;

namespace RestaurantReviewWeb
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string Id = txtId.Text;
            string UserName = txtUserName.Text;
            string Password = txtPassword.Text;
            string Role = txtRole.Text;
            string Email = txtEmail.Text;
            string Street = txtStreet.Text;
            string City = txtCity.Text;
            string State = txtState.Text;
            string Pincode = txtPincode.Text;
            string Country = txtCountry.Text;
            string PhoneNumber = txtPhoneNumber.Text;
            RestaurantBL restaurantBL = new RestaurantBL();
            CustomerEntity customer = new CustomerEntity(Id, UserName, Password, Role, Email, Street, City, State, Pincode, Country, PhoneNumber);
            int rows= restaurantBL.RegisterIntermediate(customer);
            if (rows > 0)
            {
                Response.Write("Registration Successful");
            }
            else
            {
                Response.Write("Registration Unsuccessful");
            }
        }

        protected void txtStreet_TextChanged(object sender, EventArgs e)
        {

        }
    }
}