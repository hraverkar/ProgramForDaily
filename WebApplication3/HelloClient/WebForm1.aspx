<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="HelloClient.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
       <table style="font-family: Arial">
         <tr>
           <td>
             <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
             <asp:Button ID="Button1" runat="server" Text="Get Message" OnClick="Button1_Click" />
           </td>
         </tr>
         <tr>
           <td>
             <asp:Label ID="Label1" runat="server" Font-Bold="True"></asp:Label>
           </td>
         </tr>
       </table>
      
      <table style="font-family: Arial">
        <tr>
          <td>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <asp:Button ID="Button2" runat="server" Text="Get DOB" OnClick="Button2_Click" />
          </td>
        </tr>
        <tr>
          <td>
            <asp:Label ID="Label2" runat="server" Font-Bold="True"></asp:Label>
          </td>
        </tr>
      </table>
        </div>
    </form>
</body>
</html>
