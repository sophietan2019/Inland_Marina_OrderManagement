using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using MarinaData;

namespace MarinaApp
{
    public partial class Lease_Slip : System.Web.UI.Page
    {
        public object Utilites { get; private set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var mgr = MarinaManager.GetAllDocksAsList();
                uxDocks.DataSource = mgr;
                uxDocks.DataValueField = "ID";
                uxDocks.DataTextField = "Name";
                uxDocks.DataBind();

            }

            var id = Convert.ToInt32(uxDocks.SelectedValue);
            var sliplist = MarinaManager.GetSelectedSlip(id);
            uxSelectedSlips.DataSource = sliplist;
            uxSelectedSlips.DataBind();

            HttpContext context = HttpContext.Current;

            var userId = Convert.ToInt32(context.Session["ID"]);
            var lease = MarinaManager.GetCustomerLease(userId).ToList();
            uxLease.DataSource = lease;
            uxLease.DataBind();
        }



        protected void uxSelectedSlips_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblSelectedSlipID.Text = uxSelectedSlips.SelectedDataKey.Value.ToString();
        }

        protected void btnLease_Click(object sender, EventArgs e)
        {
            if (lblSelectedSlipID.Text != "")
            {
                var aID = Convert.ToInt32(lblSelectedSlipID.Text);
                HttpContext context = HttpContext.Current;
                var userId = Convert.ToInt32(context.Session["ID"]);
                MarinaManager.AddNewLease(aID,userId);
               
            }

        }
    }
    }
    
