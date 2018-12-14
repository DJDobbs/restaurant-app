using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace restaurant_app {
    public partial class ChangeStatus : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            int number = Convert.ToInt32(Request.Params["number"]);
            string status = Request.Params["status"].ToString();
            SqlCommand sCommand = new SqlCommand();
            DataTable dTable = new DataTable();
            using (SqlConnection sConnection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\DJD\\Documents\\Visual Studio 2017\\Projects\\restaurant-app\\restaurant-app\\App_Data\\Database.mdf\";Integrated Security = True")) {
                using (sCommand=new SqlCommand("UPDATE Orders SET Status = '" + status + "' WHERE ID=" + number, sConnection)) {
                    sConnection.Open();
                    sCommand.ExecuteNonQuery();
                    sConnection.Close();
                }
                Response.Redirect("OrdersPage.aspx");
            }
        }
    }
}