using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TryIt_WebApplication
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void txtbox_Stemming_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btn_Stemming_Click(object sender, EventArgs e)
        {
            MyService.Service1Client prxy = new MyService.Service1Client();
            txtbox_Stemming_Result.Text = prxy.Stemming(txtbox_Stemming.Text);
        }

        protected void txtbox_WordFilter_input_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btn_WordFilter_Click(object sender, EventArgs e)
        {
            MyService.Service1Client prxy = new MyService.Service1Client();
            lbl_WordFilter_Result.Text = prxy.WordFilter(txtbox_WordFilter_input.Text);
        }
    }
}