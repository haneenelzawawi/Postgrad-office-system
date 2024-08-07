using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PostGradOffice
{
    public partial class StudentRegister : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RegisterG_Click(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["PostGradOffice"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            String first = First.Text;
            String last = Last.Text;
            String faculty = Faculty.Text;
            String mail = Email.Text;
            String pass = Password.Text;
            String address = Address.Text;
            int gucian = Int16.Parse(Gucian.Text);

            SqlCommand studentRegisterProc = new SqlCommand("studentRegister", conn);
            studentRegisterProc.CommandType = CommandType.StoredProcedure;

            studentRegisterProc.Parameters.Add(new SqlParameter("@first_name", first));
            studentRegisterProc.Parameters.Add(new SqlParameter("@last_name", last));
            studentRegisterProc.Parameters.Add(new SqlParameter("@password", pass));
            studentRegisterProc.Parameters.Add(new SqlParameter("@faculty", faculty));
            studentRegisterProc.Parameters.Add(new SqlParameter("@Gucian", gucian));
            studentRegisterProc.Parameters.Add(new SqlParameter("@email", mail));
            studentRegisterProc.Parameters.Add(new SqlParameter("@address", address));

            if (first == "")
            {
                Response.Write("Please Enter Your First Name");
            }
            else
           if (last == "")
            {
                Response.Write("Please Enter Your Last Name");
            }
            else
           if (faculty == "")
            {
                Response.Write("Please Enter Your Faculty");
            }
            else
           if (mail == "")
            {
                Response.Write("Please Enter Your Email");
            }
            else
            if (pass == "")
            {
                Response.Write("Please Enter Your Password");
            }
            else
            if (address == "")
            {
                Response.Write("Please Enter Your Address");
            }
            else
            {
                if (gucian == 0)
                {
                    Response.Redirect("GucianHome.aspx");
                }
                else
                if(gucian==1)
                {
                    Response.Redirect("NonGucianHome.aspx");
                }
                else
                {
                    Response.Write("Please Enter Valid Input");
                }
            }

        }
    }
}