using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(Helper.GetCon());
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        cmd.Connection = con;
        con.Open();
        cmd.CommandText = "select Username from redbullReg where Username=@user and Password=@pwd ";
        cmd.Parameters.AddWithValue("@user", UserName.Text.Replace("'", ""));
        cmd.Parameters.AddWithValue("@pwd", Password.Text.Replace("'", ""));
        dr = cmd.ExecuteReader();
        if (dr.HasRows)
        {
            while (dr.Read())
            {
             
                Response.Redirect("Welcome.aspx");
            }
        }
        else
        {
            Validator.Text = "Invalid Username/Password";
        }
        dr.Close();
        con.Close();
    }
    }
    