using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantReviewDAL;
using RestaurantReviewEntity;
using System.Web.UI.WebControls;

namespace RestaurantReviewBL
{
    public class RestaurantBL
    {
        AccountRepository repository = new AccountRepository();
        public string LoginIntermediate(string UserName,string Password)
        {
            
            string role=repository.LoginUser(UserName, Password);
            return role;

        }
        public int RegisterIntermediate(CustomerEntity customer)
        {
            int rows = repository.RegisterCustomerDetails(customer);
            return rows;
       }
        public void BindDataBl(GridView Gridview1)
        {
            repository.ViewCustomer(Gridview1);
        }
        public void DeleteBl(string UserName)
        {
            repository.DeleteCustomer(UserName);
        }
        //public void UpdateBl(string UserName, string Password, string Email, string Street, string City, string State, string Pincode, string Country, string PhoneNumber))
        //{
           
        //}
       

    }
}
