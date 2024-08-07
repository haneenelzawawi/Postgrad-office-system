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
    public partial class ExaminerRegister : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RegisterE_Click(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["PostGradOffice"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            String first = First.Text;
            String last = Last.Text;
            String field = Field.Text;
            String mail = Email.Text;
            String pass = Password.Text;
            int nationality = Int16.Parse(Nationality.Text);

            SqlCommand examinerRegisterProc = new SqlCommand("examinerRegister", conn);
            examinerRegisterProc.CommandType = CommandType.StoredProcedure;

            examinerRegisterProc.Parameters.Add(new SqlParameter("@first_name", first));
            examinerRegisterProc.Parameters.Add(new SqlParameter("@last_name", last));
            examinerRegisterProc.Parameters.Add(new SqlParameter("@password", pass));
            examinerRegisterProc.Parameters.Add(new SqlParameter("@fieldOfWork",field ));
            examinerRegisterProc.Parameters.Add(new SqlParameter("@isNational", nationality));
            examinerRegisterProc.Parameters.Add(new SqlParameter("@email", mail));

            if(first == "")
            {
                Response.Write("Please Enter Your First Name");
            }
            else
           if (last == "")
            {
                Response.Write("Please Enter Your Last Name");
            }
            else
           if (field == "")
            {
                Response.Write("Please Enter Your Field Of Work");
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
            if (nationality != 0 || nationality != 1)
            {
                Response.Write("Please Enter Valid Input");
            }
               
            else
            {
                Response.Redirect("ExaminerHome.aspx");
            }

        }
    }
}