using System;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using RestaurantReviewBL;

namespace RestaurantReviewWeb
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           
            string UserName = txtUserName.Text;
            string Password = txtPassword.Text;
            RestaurantBL restaurant = new RestaurantBL();
            string Role=restaurant.LoginIntermediate(UserName, Password);
           
            //if (rows > 0)
            //{
            //    Response.Redirect("Login Successful");
            //}
            //else
            //{
            //    Response.Redirect("Login Unsuccessful");
            //}
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Register.aspx");
        }
    }
}