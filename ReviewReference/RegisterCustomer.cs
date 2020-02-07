using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace ReviewReference
{
   public class RegisterCustomer
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
               //cmd.Parameters.AddWithValue("@ConfirmPassword", txtConfirmPassword.Text);
                cmd.Parameters.AddWithValue("@Email", customer.Email);
                cmd.Parameters.AddWithValue("@Street", customer.Street);
                cmd.Parameters.AddWithValue("@City", customer.City);
                cmd.Parameters.AddWithValue("@State", customer.State);
                cmd.Parameters.AddWithValue("@Pincode", customer.Pincode);
                cmd.Parameters.AddWithValue("@Country", customer.Country);
                cmd.Parameters.AddWithValue("@PhoneNumber", customer.PhoneNumber);
                connection.Open();
                int rows = cmd.ExecuteNonQuery();
                connection.Close();
                return rows;
            }
        }
                
    }
}
