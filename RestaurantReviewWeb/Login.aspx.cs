using System;
using System.Data.SqlClient;
using System.Data;


namespace RestaurantReviewWeb
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-968MHKC\SQLEXPRESS;Initial Catalog=RestaurantReview;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("sp_Select", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@UserName", txtUserName.Text);
            cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("SampleGrid.aspx");
        }
    }
}