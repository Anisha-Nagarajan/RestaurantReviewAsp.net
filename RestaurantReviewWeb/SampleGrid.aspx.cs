using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using RestaurantReviewDAL;
using RestaurantReviewEntity;
using RestaurantReviewBL;

namespace RestaurantReviewWeb
{
    public partial class SampleGrid : System.Web.UI.Page
    {
        //AccountRepository repository = new AccountRepository();
        RestaurantBL restaurantBl = new RestaurantBL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                BindData();
            }
        }
        public void BindData()
        {
            restaurantBl.BindDataBl(GridView1);
            //repository.ViewCustomer(GridView1);

        }
        protected void RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
           
            string UserName = GridView1.DataKeys[e.RowIndex].Values["UserName"].ToString();
            restaurantBl.DeleteBl(UserName);
            //repository.DeleteCustomer(UserName);
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


            TextBox txtId = GridView1.Rows[e.RowIndex].FindControl("txtId") as TextBox;
            TextBox txtUserName = GridView1.Rows[e.RowIndex].FindControl("txtUserName") as TextBox;
            TextBox txtPassword = GridView1.Rows[e.RowIndex].FindControl("txtPassword") as TextBox;
            TextBox txtRole = GridView1.Rows[e.RowIndex].FindControl("txtRole") as TextBox;
            TextBox txtEmail = GridView1.Rows[e.RowIndex].FindControl("txtEmail") as TextBox;
            TextBox txtStreet = GridView1.Rows[e.RowIndex].FindControl("txtStreet") as TextBox;
            TextBox txtCity = GridView1.Rows[e.RowIndex].FindControl("txtCity") as TextBox;
            TextBox txtState = GridView1.Rows[e.RowIndex].FindControl("txtState") as TextBox;
            TextBox txtPincode = GridView1.Rows[e.RowIndex].FindControl("txtPincode") as TextBox;
            TextBox txtCountry = GridView1.Rows[e.RowIndex].FindControl("txtCountry") as TextBox;
            TextBox txtPhoneNumber = GridView1.Rows[e.RowIndex].FindControl("txtPhoneNumber") as TextBox;
            string UsrName = GridView1.DataKeys[e.RowIndex].Values["UserName"].ToString();

            CustomerEntity customer = new CustomerEntity(txtId.Text,txtUserName.Text, txtPassword.Text,txtRole.Text, txtEmail.Text, txtStreet.Text, txtCity.Text, txtState.Text, txtPincode.Text, txtCountry.Text, txtPhoneNumber.Text);
            AccountRepository repository = new AccountRepository();
            int rows=repository.UpdateCustomer(customer);
            if (rows > 0)
            {
                Response.Write("Successfully updated");
            }
            else
            {
                Response.Write("Cannot update");
            }
            GridView1.EditIndex = -1;
            BindData();


        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            TextBox txtNewId = (TextBox)GridView1.FooterRow.FindControl("txtNewId");
            TextBox txtNewUserName = (TextBox)GridView1.FooterRow.FindControl("txtNewUserName");
            TextBox txtNewPassword = (TextBox)GridView1.FooterRow.FindControl("txtNewPassword");
            TextBox txtNewRole = (TextBox)GridView1.FooterRow.FindControl("txtNewRole");
            TextBox txtNewEmail = (TextBox)GridView1.FooterRow.FindControl("txtNewEmail");
            TextBox txtNewStreet = (TextBox)GridView1.FooterRow.FindControl("txtNewStreet");
            TextBox txtNewCity = (TextBox)GridView1.FooterRow.FindControl("txtNewCity");
            TextBox txtNewState = (TextBox)GridView1.FooterRow.FindControl("txtNewState");
            TextBox txtNewPincode = (TextBox)GridView1.FooterRow.FindControl("txtNewPincode");
            TextBox txtNewCountry = (TextBox)GridView1.FooterRow.FindControl("txtNewCountry");
            TextBox txtNewPhoneNumber = (TextBox)GridView1.FooterRow.FindControl("txtNewPhoneNumber");

            CustomerEntity customer = new CustomerEntity(txtNewId.Text,txtNewUserName.Text,txtNewPassword.Text,txtNewRole.Text,txtNewEmail.Text,txtNewStreet.Text,txtNewCity.Text,txtNewState.Text,txtNewPincode.Text,txtNewCountry.Text,txtNewPhoneNumber.Text);
            AccountRepository repository = new AccountRepository();
            int rows=repository.RegisterCustomerDetails(customer);
            if (rows > 0)
            {
                Response.Write("Successfully Added");
            }
            else
            {
                Response.Write("Cannot be added");
            }
            BindData();
      }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}