using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Chashvalidation
{
    public partial class ValidationDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                // Your code to process the form data
                lblValidationResult.Text = "Form submitted successfully!";
            }
            else
            {
                lblValidationResult.Text = "Please fix the validation errors.";
            }
        }
    }
}