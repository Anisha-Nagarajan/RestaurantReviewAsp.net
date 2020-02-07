using System;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace RestaurantReviewWeb
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string ConnectionStr = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            SqlConnection con = new SqlConnection(ConnectionStr);
            SqlCommand cmd = new SqlCommand("sp_Select", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@UserName", txtUserName.Text);
            cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
            con.Open();
            int rows=cmd.ExecuteNonQuery();
            con.Close();
            if (rows > 0)
            {
                Response.Redirect("Login Successful");
            }
            else
            {
                Response.Redirect("Login Unsuccessful");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("SampleGrid.aspx");
        }
    }
}