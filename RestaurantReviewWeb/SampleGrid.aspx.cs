using System;
using System.Collections.Generic;
using System.Configuration;
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

            string ConnectionStr = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            SqlConnection con = new SqlConnection(ConnectionStr);
            SqlCommand cmd = new SqlCommand("sp_View", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
        protected void RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string ConnectionStr = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            SqlConnection con = new SqlConnection(ConnectionStr);
            string UserName = GridView1.DataKeys[e.RowIndex].Values["UserName"].ToString();
             con.Open();
             SqlCommand cmd = new SqlCommand("sp_Delete", con);
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

            string ConnectionStr = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            SqlConnection con = new SqlConnection(ConnectionStr);
            TextBox txtUserName = GridView1.Rows[e.RowIndex].FindControl("txtUserName") as TextBox;
            TextBox txtPassword = GridView1.Rows[e.RowIndex].FindControl("txtPassword") as TextBox;
            TextBox txtEmail = GridView1.Rows[e.RowIndex].FindControl("txtEmail") as TextBox;
            TextBox txtStreet = GridView1.Rows[e.RowIndex].FindControl("txtStreet") as TextBox;
            TextBox txtCity = GridView1.Rows[e.RowIndex].FindControl("txtCity") as TextBox;
            TextBox txtState = GridView1.Rows[e.RowIndex].FindControl("txtState") as TextBox;
            TextBox txtPincode = GridView1.Rows[e.RowIndex].FindControl("txtPincode") as TextBox;
            TextBox txtCountry = GridView1.Rows[e.RowIndex].FindControl("txtCountry") as TextBox;
            TextBox txtPhoneNumber = GridView1.Rows[e.RowIndex].FindControl("txtPhoneNumber") as TextBox;
            string UsrName = GridView1.DataKeys[e.RowIndex].Values["UserName"].ToString();
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_Update", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@UserName", UsrName);
            cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
            cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
            cmd.Parameters.AddWithValue("@Street", txtStreet.Text);
            cmd.Parameters.AddWithValue("@City", txtCity.Text);
            cmd.Parameters.AddWithValue("@State", txtState.Text);
            cmd.Parameters.AddWithValue("@Pincode", txtPincode.Text);
            cmd.Parameters.AddWithValue("@Country", txtCountry.Text);
            cmd.Parameters.AddWithValue("@PhoneNumber", txtPhoneNumber.Text);
           
            int i = cmd.ExecuteNonQuery();
            con.Close();
            GridView1.EditIndex = -1;
            BindData();


        }

        protected void Insert(object sender, EventArgs e)
        {
            string ConnectionStr = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            SqlConnection con = new SqlConnection(ConnectionStr);
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_Register", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@UserName", txtNewUserName.Text.ToString());
            cmd.Parameters.AddWithValue("@Password", txtNewPassword.Text.ToString());
            cmd.Parameters.AddWithValue("@Email", txtNewEmail.Text.ToString());
            cmd.Parameters.AddWithValue("@Street", txtNewStreet.Text.ToString());
            cmd.Parameters.AddWithValue("@City", txtNewCity.Text.ToString());
            cmd.Parameters.AddWithValue("@State", txtNewState.Text.ToString());
            cmd.Parameters.AddWithValue("@Pincode", txtNewPincode.Text.ToString());
            cmd.Parameters.AddWithValue("@Country", txtNewCountry.Text.ToString());
            cmd.Parameters.AddWithValue("@PhoneNumber", txtNewPhoneNumber.Text.ToString());


        }
    }
}