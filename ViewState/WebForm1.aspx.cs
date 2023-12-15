using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ViewState
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        int ClicksCount = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack) //it checks if the page is being loaded for the first time 
            {               //or if it's being loaded in response to a user action (postback)
                TextBox1.Text = "0"; //if 1st time load the text box with "0"
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ClicksCount=ClicksCount+1;
            TextBox1.Text = ClicksCount.ToString();
        }
    }
}