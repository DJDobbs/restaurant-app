using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace restaurant_app {
    public partial class EditMenu : System.Web.UI.Page {
        SqlCommand sCommand = new SqlCommand();
        protected void Page_Load(object sender, EventArgs e) {

        }
        protected void addMenuItem(object sender, EventArgs e) {
            string name = tbName.Text.ToString();
            string price = tbPrice.Text.ToString();
            string ingredients = tbIngredients.Text.ToString();
            string allergens = tbAllergens.Text.ToString();
            using (SqlConnection sConnection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\DJD\\Documents\\Visual Studio 2017\\Projects\\restaurant-app\\restaurant-app\\App_Data\\Database.mdf\";Integrated Security = True")) {
                try {
                    using (sCommand=new SqlCommand("INSERT INTO MenuItems(Name,Price,Ingredients,Allergens) VALUES('"+name+"','"+price+"','"+ingredients+"','"+allergens+"')", sConnection)) {
                        sConnection.Open();
                        // To add or remove from the database, replace sAdapter.Fill(dTable); with sCommand.ExecuteNonQuery(); and update the SQL statement.
                        sCommand.ExecuteNonQuery();
                        sConnection.Close();
                    }
                }
                catch (SqlException ex) {

                }
            }
        }
        protected void removeMenuItem(object sender, EventArgs e) {
            string name = tbName.Text.ToString();
            using (SqlConnection sConnection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\DJD\\Documents\\Visual Studio 2017\\Projects\\restaurant-app\\restaurant-app\\App_Data\\Database.mdf\";Integrated Security = True")) {
                try {
                    using (sCommand=new SqlCommand("DELETE FROM MenuItems WHERE Name='"+name+"'", sConnection)) {
                        sConnection.Open();
                        // To add or remove from the database, replace sAdapter.Fill(dTable); with sCommand.ExecuteNonQuery(); and update the SQL statement.
                        sCommand.ExecuteNonQuery();
                        sConnection.Close();
                    }
                }
                catch (SqlException ex) {

                }
            }

        }
    }
}