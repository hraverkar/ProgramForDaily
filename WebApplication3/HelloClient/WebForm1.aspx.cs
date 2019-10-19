using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HelloClient
{
  public partial class WebForm1 : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
      var client = new HelloWorld.HelloWebServiceSoapClient();
      Label1.Text = client.GetMessage(TextBox1.Text);
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
      var cl  = new HelloDOB.DOBSoapClient();
      Label2.Text = cl.GetDob(TextBox2.Text);
    }
  }
}