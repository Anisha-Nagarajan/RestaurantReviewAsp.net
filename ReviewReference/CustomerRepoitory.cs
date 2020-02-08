using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Web.UI.WebControls;

namespace ReviewReference
{
   public class CustomerRepoitory
    {
        string ConnectionStr = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        public int RegisterCustomerDetails(CustomerEntity customer)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionStr))
            {
                SqlCommand cmd = new SqlCommand("sp_Register",connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UserName", customer.UserName);
                cmd.Parameters.AddWithValue("@Password", customer.Password);
               //cmd.Parameters.AddWithValue("@ConfirmPassword", txtConfirmPass0word.Text);
                cmd.Parameters.AddWithValue("@Email", customer.Email);
                cmd.Parameters.AddWithValue("@Street", customer.Street);
                cmd.Parameters.AddWithValue("@City", customer.City);
                cmd.Parameters.AddWithValue("@State", customer.State);
                cmd.Parameters.AddWithValue("@Pincode", customer.Pincode);
                cmd.Parameters.AddWithValue("@Country", customer.Country);
                cmd.Parameters.AddWithValue("@PhoneNumber", customer.PhoneNumber);
                connection.Open();
                int rows = cmd.ExecuteNonQuery();
              
           
                return rows;
            }
        }
       public void ViewCustomer(GridView GridView1)
        {
            using (SqlConnection con = new SqlConnection(ConnectionStr))
            {

                SqlCommand cmd = new SqlCommand("sp_View", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }

            }
        public int UpdateCustomer(CustomerEntity customer)
        {
            using (SqlConnection con = new SqlConnection(ConnectionStr))
            {
                
                SqlCommand cmd = new SqlCommand("sp_Update", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UserName", customer.UserName);
                cmd.Parameters.AddWithValue("@Password", customer.Password);
                cmd.Parameters.AddWithValue("@Email", customer.Email);
                cmd.Parameters.AddWithValue("@Street", customer.Street);
                cmd.Parameters.AddWithValue("@City", customer.City);
                cmd.Parameters.AddWithValue("@State", customer.State);
                cmd.Parameters.AddWithValue("@Pincode", customer.Pincode);
                cmd.Parameters.AddWithValue("@Country", customer.Country);
                cmd.Parameters.AddWithValue("@PhoneNumber", customer.PhoneNumber);
                con.Open();
                int rows = cmd.ExecuteNonQuery();
                return rows;
            }
        }
        public void DeleteCustomer(string UserName)
        {

            string ConnectionStr = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            using (SqlConnection con = new SqlConnection(ConnectionStr))
            {
             
                SqlCommand cmd = new SqlCommand("sp_Delete", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UserName", UserName);
                con.Open();
                int i = cmd.ExecuteNonQuery();
            }
        }
                
    }
}
