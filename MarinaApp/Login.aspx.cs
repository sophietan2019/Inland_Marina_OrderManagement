using MarinaData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MarinaApp
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void uxAuthenticate_Click(object sender, EventArgs e)
        {
            // pass the credentials to the AuthenticationManager
            CustomerDTO customer = AuthenticationManager.Authenticate(uxUserFirstname.Text, uxUserLastname.Text);
            if (customer== null)
            {
                //the customer is not authenticated so send message and return
                uxMessage.Text = "Invalid login";
                uxUserFirstname.Text = string.Empty;
                uxUserLastname.Text = string.Empty;
                uxUserFirstname.Focus();
          
                return;
            }

            //at this point, customer is not null meaning we have a valid authentication
            //so add student id to session
            Session.Add("ID",customer.ID);
            // redirect - false means no persistent cookie
            FormsAuthentication.RedirectFromLoginPage(customer.FullName, false);
        }   
    }
}