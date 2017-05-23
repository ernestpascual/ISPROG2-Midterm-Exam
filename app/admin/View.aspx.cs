using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class app_admin_View : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["code"] != null)
        {
            if (Request.QueryString["code"].ToString() ==
                ConfigurationManager.AppSettings["code"].ToString())
            {
                if (!IsPostBack)
                {
                    GetRegistrants();
                }
            }
            else
            {
                Response.Redirect("~/Default.aspx");
            }
        }
        else
            Response.Redirect("~/Default.aspx");
    }

    void GetRegistrants()
    {
        SqlConnection con = new SqlConnection(Helper.GetCon());
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandText = @"SELECT LastName + ', ' + FirstName + ' ' + MiddleName AS FullName, 
            University, Profession, Email, DateAdded FROM Registration ORDER BY DateAdded DESC";
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds, "Registrants");
        lvList.DataSource = ds;
        lvList.DataBind();
        con.Close();
        con.Dispose();
    }
    protected void lvList_PagePropertiesChanging(object sender, PagePropertiesChangingEventArgs e)
    {
        dpList.SetPageProperties(e.StartRowIndex, e.MaximumRows, false);
        GetRegistrants();
    }
}