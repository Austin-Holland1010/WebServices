using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TryIt_ElectiveServices
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            MyService.Service1Client prxy = new MyService.Service1Client();
            string strInput = txtbox_StringSort1.Text;
            int numInput = Int32.Parse(txtbox_String_Sort2.Text);
            lbl_String_Sort.Text = prxy.String_Sort(strInput, numInput);
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void txtbox_CharacterCounter_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btn_CharacterCounter_Click(object sender, EventArgs e)
        {
            MyService.Service1Client prxy = new MyService.Service1Client();
            int output = prxy.CharacterCounter(txtbox_CharacterCounter.Text);
            lbl_CharacterCounter.Text = output.ToString();
        }

        protected void txtbox_Password_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btn_Password_Click(object sender, EventArgs e)
        {
            string input = txtbox_Password.Text;

            MyService.Service1Client prxy = new MyService.Service1Client();
            bool output = prxy.Password(txtbox_Password.Text);
            if (output == true)
            {
                lbl_Password.Text = "Password Correct";
            }
            else
            {
                lbl_Password.Text = "Password Incorrect";
            }
        }

        protected void TextBox1_TextChanged1(object sender, EventArgs e)
        {

        }

        protected void btn_UpLowDouble_Click(object sender, EventArgs e)
        {
            MyService.Service1Client prxy = new MyService.Service1Client();
            string sinput = txtbox1_UpLowDouble.Text;
            int intinput = Int32.Parse(txtbox2_UpLowDouble.Text);
            string result = prxy.Upper_Lower_DoubleSpace(sinput, intinput);
            lbl_UpLowDouble.Text = result;
        }
    }
}