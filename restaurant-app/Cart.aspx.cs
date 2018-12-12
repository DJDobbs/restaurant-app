using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace restaurant_app {
    public partial class Cart : System.Web.UI.Page {
        SqlCommand sCommand;
        SqlDataAdapter sAdapter;
        SqlConnection sConnection;
        protected void Page_Load(object sender, EventArgs e) {
            DataTable dTable = new DataTable();
            using (sConnection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\DJD\\Documents\\Visual Studio 2017\\Projects\\restaurant-app\\restaurant-app\\App_Data\\Database.mdf\";Integrated Security = True")) {
                using (sCommand=new SqlCommand("SELECT * FROM CartItems", sConnection)) {
                    sAdapter = new SqlDataAdapter(sCommand);
                    sConnection.Open();
                    sAdapter.Fill(dTable);
                    sConnection.Close();
                }
                StringBuilder sBuilder = new StringBuilder();
                sBuilder.Append("<table width='100%'>");
                sBuilder.Append("<tr><th>Name</th><th>Quantity</th></tr>");
                foreach (DataRow dRow in dTable.Rows) {
                    sBuilder.Append("<tr>");
                    sBuilder.Append("<td>" + dRow["Name"].ToString().Trim() + "</td>");
                    sBuilder.Append("<td>" + dRow["Quantity"].ToString().Trim() + "</td>");
                    sBuilder.Append("</tr>");
                }
                sBuilder.Append("</table>");
                CartDisplay.Controls.Add(new LiteralControl(sBuilder.ToString()));
            }
        }

        protected void placeOrder(object sender, EventArgs e) {
            using (sConnection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\DJD\\Documents\\Visual Studio 2017\\Projects\\restaurant-app\\restaurant-app\\App_Data\\Database.mdf\";Integrated Security = True")) {
                using (sCommand=new SqlCommand("DELETE FROM CartItems;", sConnection)) {
                    sAdapter = new SqlDataAdapter(sCommand);
                    sConnection.Open();
                    sCommand.ExecuteNonQuery();
                    sConnection.Close();
                }
            }
        }


        protected void emptyCart(object sender, EventArgs e) {
            using (sConnection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\DJD\\Documents\\Visual Studio 2017\\Projects\\restaurant-app\\restaurant-app\\App_Data\\Database.mdf\";Integrated Security = True")) {
                using (sCommand=new SqlCommand("DELETE FROM CartItems;", sConnection)) {
                    sAdapter = new SqlDataAdapter(sCommand);
                    sConnection.Open();
                    sCommand.ExecuteNonQuery();
                    sConnection.Close();
                }
            }
        }
    }
}