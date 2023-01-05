using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace POC
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == true)
            {
                Label2.Text = ("Data was succesfully inserted");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection ereg_data = new SqlConnection("Server=tcp:ereg-server.database.windows.net,1433;Initial Catalog=ereg-database;Persist Security Info=False;User ID=ereg-server-admin;Password=34G323323Y325N1Y$;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            {
                SqlCommand insert = new SqlCommand("EXEC dbo.InsertPropertyName @Fullname", ereg_data);
                insert.Parameters.AddWithValue("@Fullname", TextBox1.Text);

                ereg_data.Open();   
                insert.ExecuteNonQuery();  
                ereg_data.Close();  


                if (IsPostBack)
                {
                    TextBox1.Text = "";
                }
            }
        }
    }
}