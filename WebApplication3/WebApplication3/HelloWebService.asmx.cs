﻿using System.Web.Services;

namespace WebApplication3
{
  /// <summary>
  /// Summary description for HelloWebService
  /// </summary>
  [WebService(Namespace = "http://tempuri.org/")]
  [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
  [System.ComponentModel.ToolboxItem(false)]
  // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
  // [System.Web.Script.Services.ScriptService]
  public class HelloWebService : System.Web.Services.WebService
  {

    [WebMethod]
    public string GetMessage(string name)
    {
      return "Hello World " + name;
    }

    
  }
}
