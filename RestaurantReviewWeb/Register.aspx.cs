using System;
using System.Data;
using System.Data.SqlClient;
using ReviewReference;

namespace RestaurantReviewWeb
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            CustomerRepoitory register = new CustomerRepoitory();
            CustomerEntity customer = new CustomerEntity(txtUserName.Text, txtPassword.Text, txtEmail.Text, txtStreet.Text, txtCity.Text, txtState.Text, txtPincode.Text, txtCountry.Text, txtPhoneNumber.Text);
            int rows = register.RegisterCustomerDetails(customer);
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