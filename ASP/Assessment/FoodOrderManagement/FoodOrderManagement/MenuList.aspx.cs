using System;
using System.Data;
using System.Data.SqlClient;

namespace FoodOrderManagement
{
    public partial class MenuList : System.Web.UI.Page
    {
        SqlConnection con =
            DBHelper.GetConnection();

        protected void Page_Load(object sender, EventArgs e)
        {
            // Session Checking
            if (Session["Username"] == null)
            {
                Response.Redirect("Login.aspx");
            }

            if (!IsPostBack)
            {
                LoadMenuItems();
            }
        }

        private void LoadMenuItems()
        {
            SqlDataAdapter da =
                new SqlDataAdapter(
                "SELECT * FROM MenuItems",
                con);

            DataTable dt = new DataTable();

            da.Fill(dt);

            gvMenu.DataSource = dt;
            gvMenu.DataBind();
        }

        protected void lnkDelete_Click(object sender, EventArgs e)
        {
            string id =
                ((System.Web.UI.WebControls.LinkButton)sender)
                .CommandArgument;

            SqlCommand cmd =
                new SqlCommand(
                "DELETE FROM MenuItems WHERE MenuId=@MenuId",
                con);

            cmd.Parameters.AddWithValue("@MenuId", id);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            LoadMenuItems();
        }
    }
}