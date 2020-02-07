using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RestaurantReviewWeb
{
    public partial class SampleGrid : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                BindData();
            }
        }
        public void BindData()
        {

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-968MHKC\SQLEXPRESS;Initial Catalog=RestaurantReview;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("SELECT * FROM Registration", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
        protected void RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
             SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-968MHKC\SQLEXPRESS;Initial Catalog=RestaurantReview;Integrated Security=True");
             string UserName = GridView1.DataKeys[e.RowIndex].Values["UserName"].ToString();
             con.Open();
             SqlCommand cmd = new SqlCommand("DELETE FROM Registration WHERE UserName = @UserName", con);
            cmd.Parameters.AddWithValue("UserName", UserName);
            int i = cmd.ExecuteNonQuery();
            con.Close();
            BindData();
        }
        protected void RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            BindData();
        }
        protected void RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            BindData();
        }
        protected void RowUpdating(object sender, GridViewUpdateEventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-968MHKC\SQLEXPRESS;Initial Catalog=RestaurantReview;Integrated Security=True");
            TextBox UserName = GridView1.Rows[e.RowIndex].FindControl("txtUserName") as TextBox;
            TextBox Password = GridView1.Rows[e.RowIndex].FindControl("txtPassword") as TextBox;
            TextBox Email = GridView1.Rows[e.RowIndex].FindControl("txtEmail") as TextBox;
            TextBox Street = GridView1.Rows[e.RowIndex].FindControl("txtStreet") as TextBox;
            TextBox City = GridView1.Rows[e.RowIndex].FindControl("txtCity") as TextBox;
            TextBox State = GridView1.Rows[e.RowIndex].FindControl("txtState") as TextBox;
            TextBox Pincode = GridView1.Rows[e.RowIndex].FindControl("txtPincode") as TextBox;
            TextBox Country = GridView1.Rows[e.RowIndex].FindControl("txtCountry") as TextBox;
            TextBox PhoneNumber = GridView1.Rows[e.RowIndex].FindControl("txtPhoneNumber") as TextBox;
            string UsrName = GridView1.DataKeys[e.RowIndex].Values["UserName"].ToString();
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_Update", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("UserName", txtUserName.Text);
            cmd.Parameters.AddWithValue("Password", txtPassword.Text);
            cmd.Parameters.AddWithValue("Email", txtEmail.Text);
            cmd.Parameters.AddWithValue("Street", txtStreet.Text);
            cmd.Parameters.AddWithValue("City", txtCity.Text);
            cmd.Parameters.AddWithValue("State", txtState.Text);
            cmd.Parameters.AddWithValue("Pincode", txtPincode.Text);
            cmd.Parameters.AddWithValue("Country", txtCountry.Text);
            cmd.Parameters.AddWithValue("PhoneNumber", txtPhoneNumber.Text);

            int i = cmd.ExecuteNonQuery();
            con.Close();
            GridView1.EditIndex = -1;
            BindData();


        }
    }
}