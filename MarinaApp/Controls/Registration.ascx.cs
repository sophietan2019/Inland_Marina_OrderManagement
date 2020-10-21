using MarinaData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
namespace MarinaApp.Controls
{
    public partial class Registration : System.Web.UI.UserControl
    {
        public bool IsUpdate { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsUpdate)
            {
                //get id out of session
                if (Session["ID"] != null)
                {
                    //need to convert the object in session to an int
                    var id = Convert.ToInt32(Session["ID"]);
                    //get the Authentication object from the manager
                    var auth = AuthenticationManager.Find(id);
                    //set the state of the form
                    if (auth != null)
                    {
                        txtFirstname.Text = auth.FirstName;
                        txtLastname.Text = auth.LastName;
                        txtCity.Text = auth.City;
                        txtPhone.Text = auth.Phone;
                    }
                }
            }
        }
        protected void btnSubmit_click(object sender, EventArgs e)
        {
            if (IsUpdate)
            {
                //updating the record
                //get id out of session
                if (Session["ID"] != null)
                {
                    var id = Convert.ToInt32(Session["ID"]);
                    //get the Authentication object from the manager
                    var auth = AuthenticationManager.Find(id);
                    auth.FirstName = txtFirstname.Text;
                    auth.LastName = txtLastname.Text;
                    auth.City = txtCity.Text;
                    auth.Phone = txtPhone.Text;
                    //pass auth to the manager for updating
                    AuthenticationManager.Update(auth);
                    //remove from auth ticket, clear session and redirect
                    FormsAuthentication.SignOut();
                    Session.Clear();
                    Response.Redirect("~/Registration");
                }
            }
            else
            {
                //inserting the record
                var customer = new Customer
                {
                    FirstName = txtFirstname.Text,
                    LastName = txtLastname.Text,
                    City = txtCity.Text,
                    Phone = txtPhone.Text
                };
                //pass the auth object to the manager for inserting
                AuthenticationManager.Add(customer);
                Response.Redirect("~/Login");
            }
            var user = AuthenticationManager.Authenticate(txtFirstname.Text, txtLastname.Text);
            if (user == null)
            {
                //the customer is not authenticated
                txtFirstname.Text = string.Empty;
                txtLastname.Text = string.Empty;
                txtFirstname.Focus();
                return;
            }
            //add id to session
            Session.Add("ID", ID);
            //redirect                    
            FormsAuthentication.RedirectFromLoginPage(user.FullName, false);
        }
        protected void btnReset_click(object sender, EventArgs e)
        {
            Clear();
        }
        private void Clear()
        {
            txtFirstname.Text = "";
            txtLastname.Text = "";
            txtPhone.Text = "";
            txtCity.Text = "";
        }
    }
}