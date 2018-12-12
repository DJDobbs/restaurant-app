using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace restaurant_app
{
	public partial class AddToCart : System.Web.UI.Page {
        SqlCommand sCommand = new SqlCommand();

        protected void Page_Load(object sender, EventArgs e) {
            string food = Request.Params["foodName"].ToString();
            SqlDataAdapter sAdapter = new SqlDataAdapter();
            DataTable dTable = new DataTable();
            using (SqlConnection sConnection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\DJD\\Documents\\Visual Studio 2017\\Projects\\restaurant-app\\restaurant-app\\App_Data\\Database.mdf\";Integrated Security = True")) {
                using (sCommand=new SqlCommand("INSERT INTO CartItems(Name, Quantity) VALUES('" + food + "',1);", sConnection)) {
                    sAdapter = new SqlDataAdapter(sCommand);
                    sConnection.Open();
                    // To add or remove from the database, replace sAdapter.Fill(dTable); with sCommand.ExecuteNonQuery(); and update the SQL statement.
                    sCommand.ExecuteNonQuery();
                    sConnection.Close();
                }
            }



//            AddToCartDisplay.Controls.Add(new LiteralControl(food));
        }
	}
}