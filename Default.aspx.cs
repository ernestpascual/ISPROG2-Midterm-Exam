using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    bool IsExisting(string email)
    {
        bool existing = true;
        SqlConnection con = new SqlConnection(Helper.GetCon());
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandText = @"SELECT Email FROM redbullReg WHERE Email=@Email";
        cmd.Parameters.AddWithValue("@Email", email);
        existing = cmd.ExecuteScalar() == null ? false : true;
        con.Close();
        con.Dispose();
        return existing;
    }

    protected void btnRegister_Click(object sender, EventArgs e)
    {
        bool emailExisting = IsExisting(txtEmail.Text);

        if (!emailExisting)
        {
            SqlConnection con = new SqlConnection(Helper.GetCon());
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = @"INSERT INTO redbullReg VALUES 
            (@Username, @Password, @FirstName, @MiddleName, @LastName, @Address,
            @Gender, @Email, @DateAdded)";
            cmd.Parameters.AddWithValue("@Username", txtUN.Text);
            cmd.Parameters.AddWithValue("@Password", txtPW.Text);
            cmd.Parameters.AddWithValue("@FirstName", txtFN.Text);
            cmd.Parameters.AddWithValue("@MiddleName", txtMN.Text);
            cmd.Parameters.AddWithValue("@LastName", txtLN.Text);
            cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
            cmd.Parameters.AddWithValue("@Gender", ddlGender.SelectedValue);
            cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
            cmd.Parameters.AddWithValue("@DateAdded", DateTime.Now);
            cmd.ExecuteNonQuery();
            con.Close();
            con.Dispose();
            register.Visible = true;
            email.Visible = false;
            Response.Redirect("RegisteredSplashPage.aspx");

        }
        else
        {
            register.Visible = false;
            email.Visible = true;
            Response.Redirect("Error.aspx");
        }
    }

    void ClearTextBoxes()
    {
        txtUN.Text = string.Empty;
        txtPW.Text = string.Empty;
        txtFN.Text = string.Empty;
        txtMN.Text = string.Empty;
        txtLN.Text = string.Empty;
        txtAddress.Text = string.Empty;
        ddlGender.SelectedIndex = 0;
        txtEmail.Text = string.Empty;

    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
    }
    protected void Button1_Click(object sender, EventArgs e)
    {

    }
}



   












