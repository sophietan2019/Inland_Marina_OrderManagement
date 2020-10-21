using MarinaData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MarinaApp
{
    public partial class AvailableSlips : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var mgr = MarinaManager.GetAvailableSlips();
                uxAvailableSlips.DataSource = mgr;
                uxAvailableSlips.DataBind();
            }
        }
    }
}