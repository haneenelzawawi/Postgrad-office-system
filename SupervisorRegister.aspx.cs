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
    public partial class SupervisorRegister : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RegisterS_Click(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["PostGradOffice"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            String first = First.Text;
            String last = Last.Text;
            String faculty = Faculty.Text;
            String mail = Email.Text;
            String pass = Password.Text;

            SqlCommand supervisorRegisterProc = new SqlCommand("supervisorRegister", conn);
            supervisorRegisterProc.CommandType = CommandType.StoredProcedure;


            supervisorRegisterProc.Parameters.Add(new SqlParameter("@first_name", first));
            supervisorRegisterProc.Parameters.Add(new SqlParameter("@last_name", last));
            supervisorRegisterProc.Parameters.Add(new SqlParameter("@password", pass));
            supervisorRegisterProc.Parameters.Add(new SqlParameter("@faculty", faculty));
            supervisorRegisterProc.Parameters.Add(new SqlParameter("@email", mail));

            if (first == "")
            {
                Response.Write("Please Enter Your First Name");
            }
            else
            if(last == "")
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
            {
                Response.Redirect("SupervisorHome.aspx");
            }


        }
    }
}