using System;
using System.Data.SqlClient;

namespace FoodOrderManagement
{
    public partial class MenuDetails : System.Web.UI.Page
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
                LoadDetails();
            }
        }

        private void LoadDetails()
        {
            int id =
                Convert.ToInt32(
                Request.QueryString["MenuId"]);

            SqlCommand cmd =
                new SqlCommand(
                "SELECT * FROM MenuItems WHERE MenuId=@MenuId",
                con);

            cmd.Parameters.AddWithValue("@MenuId", id);

            con.Open();

            SqlDataReader dr =
                cmd.ExecuteReader();

            if (dr.Read())
            {
                lblMenuId.Text =
                    dr["MenuId"].ToString();

                lblItemName.Text =
                    dr["ItemName"].ToString();

                lblCategory.Text =
                    dr["Category"].ToString();

                lblFoodType.Text =
                    dr["FoodType"].ToString();

                lblPrice.Text =
                    dr["Price"].ToString();

                lblQuantity.Text =
                    dr["AvailableQuantity"].ToString();

                lblAvailable.Text =
                    Convert.ToBoolean(dr["IsAvailable"])
                    ? "Yes"
                    : "No";

                lblCreatedDate.Text =
                    dr["CreatedDate"].ToString();
            }

            con.Close();
        }
    }
}