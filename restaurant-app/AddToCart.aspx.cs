using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace restaurant_app {
    public partial class AddToCart : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

            string food = Request.Params["foodID"].ToString();

            CartDisplay.Controls.Add(new LiteralControl(food));
        }
    }
}