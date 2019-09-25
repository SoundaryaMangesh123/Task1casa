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
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void ButtonAdd_Click(object sender, EventArgs e)
        {
            int UserId = Convert.ToInt32(TextUSerID.Text);
            string UserName = TextUName.Text;
           

            SqlConnection myConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["CarFactoryConnectionString"].ConnectionString);
            myConnection.Open();

            string query = "Insert into [dbo].[Users] (UserID,UserName) Values (@User_ID,@User_Name)";

            SqlCommand insertCommand = new SqlCommand(query, myConnection);
            insertCommand.Parameters.AddWithValue("@User_ID", UserId);
            insertCommand.Parameters.AddWithValue("@User_Name", UserName);
            insertCommand.ExecuteNonQuery();
            myConnection.Close();

            Response.Redirect(Request.RawUrl);
        }
    }
}