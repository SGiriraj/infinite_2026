using System;

namespace Product_Dropdown
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedItem.Text == "Mobile")
            {
                Image1.ImageUrl = "Images/phone.jpg";
            }

            else if (DropDownList1.SelectedItem.Text == "Laptop")
            {
                Image1.ImageUrl = "Images/Laptop.jpg";
            }

            else if (DropDownList1.SelectedItem.Text == "Headphone")
            {
                Image1.ImageUrl = "Images/headphone.jpg";
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedItem.Text == "Mobile")
            {
                Label1.Text = "Price : Rs.15000";
            }

            else if (DropDownList1.SelectedItem.Text == "Laptop")
            {
                Label1.Text = "Price : Rs.50000";
            }

            else if (DropDownList1.SelectedItem.Text == "Headphone")
            {
                Label1.Text = "Price : Rs.2000";
            }

            else
            {
                Label1.Text = "Please Select a Product";
            }
        }
    }
}