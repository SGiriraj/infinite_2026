using System;
using System.Data.SqlClient;

namespace FoodOrderManagement
{
    public partial class AddEditMenu : System.Web.UI.Page
    {
        SqlConnection con =
            DBHelper.GetConnection();

        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (Session["Username"] == null)
            {
                Response.Redirect("Login.aspx");
            }

            if (!IsPostBack)
            {
                
                if (Request.QueryString["MenuId"] != null)
                {
                    LoadMenuData();
                }
            }
        }

        private void LoadMenuData()
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
                txtItemName.Text =
                    dr["ItemName"].ToString();

                ddlCategory.SelectedValue =
                    dr["Category"].ToString();

                rblFoodType.SelectedValue =
                    dr["FoodType"].ToString();

                txtPrice.Text =
                    dr["Price"].ToString();

                txtQuantity.Text =
                    dr["AvailableQuantity"].ToString();

                chkAvailable.Checked =
                    Convert.ToBoolean(dr["IsAvailable"]);
            }

            con.Close();
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            
            if (Request.QueryString["MenuId"] != null)
            {
                UpdateMenu();
            }
            else
            {
                InsertMenu();
            }
        }

        private void InsertMenu()
        {
            SqlCommand cmd =
                new SqlCommand(
                "INSERT INTO MenuItems(ItemName,Category,FoodType,Price,AvailableQuantity,IsAvailable,CreatedDate) VALUES(@ItemName,@Category,@FoodType,@Price,@Qty,@Available,GETDATE())",
                con);

            cmd.Parameters.AddWithValue("@ItemName", txtItemName.Text);
            cmd.Parameters.AddWithValue("@Category", ddlCategory.SelectedValue);
            cmd.Parameters.AddWithValue("@FoodType", rblFoodType.SelectedValue);
            cmd.Parameters.AddWithValue("@Price", txtPrice.Text);
            cmd.Parameters.AddWithValue("@Qty", txtQuantity.Text);
            cmd.Parameters.AddWithValue("@Available", chkAvailable.Checked);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            Response.Redirect("MenuList.aspx");
        }

        private void UpdateMenu()
        {
            int id =
                Convert.ToInt32(
                Request.QueryString["MenuId"]);

            SqlCommand cmd =
                new SqlCommand(
                "UPDATE MenuItems SET ItemName=@ItemName, Category=@Category, FoodType=@FoodType, Price=@Price, AvailableQuantity=@Qty, IsAvailable=@Available WHERE MenuId=@MenuId",
                con);

            cmd.Parameters.AddWithValue("@ItemName", txtItemName.Text);
            cmd.Parameters.AddWithValue("@Category", ddlCategory.SelectedValue);
            cmd.Parameters.AddWithValue("@FoodType", rblFoodType.SelectedValue);
            cmd.Parameters.AddWithValue("@Price", txtPrice.Text);
            cmd.Parameters.AddWithValue("@Qty", txtQuantity.Text);
            cmd.Parameters.AddWithValue("@Available", chkAvailable.Checked);
            cmd.Parameters.AddWithValue("@MenuId", id);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            Response.Redirect("MenuList.aspx");
        }
    }
}