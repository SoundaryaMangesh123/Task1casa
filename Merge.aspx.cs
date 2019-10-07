using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace CarDealership
{
    public partial class Merge : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void ButtonAdd_Click(object sender, EventArgs e)
        {
            string MName = TextBox3.Text;
            string MLocation = TextBox4.Text;
            string userId = TextBox1.Text;
            string userName = TextBox2.Text;

            SqlConnection myConnection1 = new SqlConnection(ConfigurationManager.ConnectionStrings["CarFactoryConnectionString"].ConnectionString);
            myConnection1.Open();

            string query1 = "Insert into [dbo].[Users] (UserID,UserName) Values (@User_ID,@User_Name)";

            SqlCommand insertCommand1 = new SqlCommand(query1, myConnection1);
            insertCommand1.Parameters.AddWithValue("@User_ID", userId);
            insertCommand1.Parameters.AddWithValue("@User_Name", userName);
            insertCommand1.ExecuteNonQuery();
            myConnection1.Close();

            SqlConnection myConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["CarFactoryConnectionString"].ConnectionString);
            myConnection.Open();

            string query = "Insert into [dbo].[Manufacturers] (Mf_Name,Mf_Location,UserID) Values (@Mf_Name,@Mf_Location,@UserId)";

            SqlCommand insertCommand = new SqlCommand(query, myConnection);
            insertCommand.Parameters.AddWithValue("@Mf_Name", MName);
            insertCommand.Parameters.AddWithValue("@Mf_Location", MLocation);
            insertCommand.Parameters.AddWithValue("@UserId", userId);
            insertCommand.ExecuteNonQuery();
            myConnection.Close();

           

            Response.Redirect(Request.RawUrl);
        }
    }
}