using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PostGradOffice
{
    public partial class RegisterHome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void Supervisor_Click(object sender, EventArgs e)
        {
            Response.Redirect("SupervisorRegister.aspx");
        }

        protected void Examiner_Click(object sender, EventArgs e)
        {

        }

        protected void Student_Click(object sender, EventArgs e)
        {
            Response.Redirect("StudentRegister.aspx");
        }
    }
}