using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace WebApplication3
{
    public partial class CustomerRegister : System.Web.UI.Page
    {
        
        string conStr =
            ConfigurationManager
            .ConnectionStrings["BankDBConnection"]
            .ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadCustomers();
            }
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            string filePath = "";

            if (fuIDProof.HasFile)
            {
                string folderPath =
                    Server.MapPath("~/IDProofs/");

                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }

                string fileName =
                    Path.GetFileName(fuIDProof.FileName);

                string fullPath =
                    Path.Combine(folderPath, fileName);

                fuIDProof.SaveAs(fullPath);

                filePath =
                    "~/IDProofs/" + fileName;
            }

            SqlConnection con =
                new SqlConnection(conStr);

            string query =
                @"INSERT INTO BankCustomer
                (
                    FullName,
                    Email,
                    Mobile,
                    Gender,
                    Address,
                    City,
                    AccountType,
                    Balance,
                    IDProofPath
                )

                VALUES
                (
                    @FullName,
                    @Email,
                    @Mobile,
                    @Gender,
                    @Address,
                    @City,
                    @AccountType,
                    @Balance,
                    @IDProofPath
                )";

            SqlCommand cmd =
                new SqlCommand(query, con);

            cmd.Parameters.AddWithValue(
                "@FullName",
                txtName.Text);

            cmd.Parameters.AddWithValue(
                "@Email",
                txtEmail.Text);

            cmd.Parameters.AddWithValue(
                "@Mobile",
                txtMobile.Text);

            cmd.Parameters.AddWithValue(
                "@Gender",
                rblGender.SelectedValue);

            cmd.Parameters.AddWithValue(
                "@Address",
                txtAddress.Text);

            cmd.Parameters.AddWithValue(
                "@City",
                ddlCity.SelectedValue);

            cmd.Parameters.AddWithValue(
                "@AccountType",
                ddlAccountType.SelectedValue);

            cmd.Parameters.AddWithValue(
                "@Balance",
                Convert.ToDecimal(txtBalance.Text));

            cmd.Parameters.AddWithValue(
                "@IDProofPath",
                filePath);

            con.Open();

            cmd.ExecuteNonQuery();

            con.Close();

            lblMessage.Text =
                "Customer Registered Successfully";

            LoadCustomers();

            ClearControls();
        }

        
        private void LoadCustomers()
        {
            SqlConnection con =
                new SqlConnection(conStr);

            string query =
                "SELECT * FROM BankCustomer";

            SqlDataAdapter da =
                new SqlDataAdapter(query, con);

            DataTable dt =
                new DataTable();

            da.Fill(dt);

            gvCustomers.DataSource = dt;

            gvCustomers.DataBind();
        }

       
        private void ClearControls()
        {
            txtName.Text = "";
            txtEmail.Text = "";
            txtMobile.Text = "";
            txtAddress.Text = "";
            txtBalance.Text = "";

            ddlCity.SelectedIndex = 0;

            ddlAccountType.SelectedIndex = 0;
        }
    }
}