using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.Caching;

namespace FoodOrderManagement
{
    public partial class OrderStats : System.Web.UI.Page
    {
        SqlConnection con =
            DBHelper.GetConnection();

        protected void Page_Load(object sender, EventArgs e)
        {
            // Session Check
            if (Session["Username"] == null)
            {
                Response.Redirect("Login.aspx");
            }

            if (!IsPostBack)
            {
                // Application State
                lblTotalUsers.Text =
                    Application["TotalUsers"].ToString();

                lblActiveUsers.Text =
                    Application["ActiveUsers"].ToString();

                LoadCategoryStats();
            }
        }

        private void LoadCategoryStats()
        {
            // Cache Checking
            if (Cache["FoodCategoryStats"] == null)
            {
                SqlDataAdapter da =
                    new SqlDataAdapter(
                    "SELECT Category, COUNT(*) AS TotalItems FROM MenuItems GROUP BY Category",
                    con);

                DataTable dt = new DataTable();

                da.Fill(dt);

                // Insert into Cache
                Cache.Insert(
                    "FoodCategoryStats",
                    dt,
                    null,
                    DateTime.Now.AddMinutes(5),
                    Cache.NoSlidingExpiration);

                gvStats.DataSource = dt;
                gvStats.DataBind();
            }
            else
            {
                gvStats.DataSource =
                    (DataTable)Cache["FoodCategoryStats"];

                gvStats.DataBind();
            }
        }
    }
}